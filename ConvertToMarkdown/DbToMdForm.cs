using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace test
{
    public partial class DbToMdForm : Sunny.UI.UIForm
    {
        public DbToMdForm()
        {
            InitializeComponent();
        }

        private void btnSelectDb_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //SqlConnection connection = new SqlConnection(builder.ConnectionString);
            SqlConnection connection = new SqlConnection();
            if (string.IsNullOrWhiteSpace(txtConnectionString.Text.Trim()))
            {
                builder.DataSource = ".";
                builder.InitialCatalog = "master";
                builder.IntegratedSecurity = true;
                connection.ConnectionString = builder.ConnectionString;
            }
            else
            {
                connection.ConnectionString = txtConnectionString.Text.Trim();
            }

            try
            {
                connection.Open();
                loadTable(connection);
                MessageBox.Show("连接成功");
                txtConnectionString.Text = connection.ConnectionString;
                lblStatus.Text = "已选择数据库";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void loadTable(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT name,create_date FROM sys.tables", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbTbList.Items.Add(reader[0].ToString());
                cbTableList.Items.Add(reader[0].ToString());
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                MessageBox.Show("请先选择数据库");
                return;
            }

            StringBuilder sb = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(txtConnectionString.Text))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT name,create_date FROM sys.tables", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                sb.AppendLine("| 表名 | 创建时间 |");
                sb.AppendLine("| --- | --- |");

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    DateTime createDate = reader.GetDateTime(1);
                    sb.AppendLine($"| {name} | {createDate} |");
                }
            }
            txtResult.Text = sb.ToString();
            MessageBox.Show("转换完成");
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {
        }

        private async void btnConvertTbSchema_ClickAsync(object sender, EventArgs e)
        {
            // 获取所选表名
            string selectedTableName = cbTableList.SelectedItem.ToString();
            StringBuilder sb = new StringBuilder();
          
            // 创建数据库连接对象并打开连接
            using (SqlConnection conn = new SqlConnection(txtConnectionString.Text))
            {
                conn.Open();
                // 获取表结构信息
                DataTable dt = await Task.Run(() => conn.GetSchema("Columns", new string[] { null, null, selectedTableName }));
                // 将表结构信息转换为Markdown格式
                sb.AppendLine("| 列名 | 数据类型 | 允许NULL值 |");
                sb.AppendLine("| --- | --- | --- |");
                foreach (DataRow row in dt.Rows)
                {
                    string columnName = row["COLUMN_NAME"].ToString();
                    string dataType = row["DATA_TYPE"].ToString();
                    string isNullable = row["IS_NULLABLE"].ToString() == "YES" ? "是" : "否";
                    sb.AppendLine($"| {columnName} | {dataType} | {isNullable} |");
                }
            }

            // 显示Markdown格式的表结构信息
            txtTableSchemaResult.Text = sb.ToString();
            MessageBox.Show("您选择了表：" + selectedTableName + "转换完成");

        }

        private async void btnConvertTbData_ClickAsync(object sender, EventArgs e)
        {
            // 获取所选表名
            string selectedTableName = cbTbList.SelectedItem.ToString();
            var query = $"SELECT top 100 * FROM {selectedTableName}";
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(txtConnectionString.Text))
            {
                var command = new SqlCommand(query, connection);
                var dataAdapter = new SqlDataAdapter(command);
                await Task.Run(() => dataAdapter.Fill(dataTable));
            }
            var columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            var markdown = $"|{string.Join("|", columnNames)}|\n|{string.Join("|", columnNames.Select(_ => "---"))}|\n";

            foreach (DataRow row in dataTable.Rows)
            {
                var cells = row.ItemArray.Select(cell => cell.ToString());
                markdown += $"|{string.Join("|", cells)}|\n";
            }
            txtTableResult.Text = markdown;
            MessageBox.Show("您选择了表：" + selectedTableName + "转换完成");
        }




    }
}