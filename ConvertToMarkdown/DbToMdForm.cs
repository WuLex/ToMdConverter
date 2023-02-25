using System.Text;
using System;
using System.Data.SqlClient;

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
            builder.DataSource = ".";
            builder.InitialCatalog = "master";
            builder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                MessageBox.Show("���ӳɹ�");
                txtConnectionString.Text = connection.ConnectionString;
                lblStatus.Text = "��ѡ�����ݿ�";
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                MessageBox.Show("����ѡ�����ݿ�");
                return;
            }

            StringBuilder sb = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(txtConnectionString.Text))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT name,create_date FROM sys.tables", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                sb.AppendLine("| ���� | ����ʱ�� |");
                sb.AppendLine("| --- | --- |");

                while (reader.Read())
                {

                    string name = reader.GetString(0);
                    DateTime createDate = reader.GetDateTime(1);
                    sb.AppendLine($"| {name} | {createDate} |");
                }
            }
            txtResult.Text = sb.ToString();
            MessageBox.Show("ת�����");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}