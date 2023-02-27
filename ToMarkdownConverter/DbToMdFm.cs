using System.Data;
using System.Data.SqlClient;

namespace SqlTableToMarkdown
{
    public partial class DbToMdFm : Form
    {
        private const string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;";
        private const string tableName = "myTableName";

        public DbToMdFm()
        {
            InitializeComponent();
        }

        private async Task<string> GetMarkdownTableAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = $"SELECT * FROM {tableName}";
                var command = new SqlCommand(query, connection);
                var dataAdapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                await Task.Run(() => dataAdapter.Fill(dataTable));

                var columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                var markdown = $"|{string.Join("|", columnNames)}|\n|{string.Join("|", columnNames.Select(_ => "---"))}|\n";

                foreach (DataRow row in dataTable.Rows)
                {
                    var cells = row.ItemArray.Select(cell => cell.ToString());
                    markdown += $"|{string.Join("|", cells)}|\n";
                }
                return markdown;
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            var markdown = await GetMarkdownTableAsync();
            var saveFileDialog = new SaveFileDialog { Filter = "Markdown files (*.md)|*.md" };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() => File.WriteAllText(saveFileDialog.FileName, markdown));
            }
        }

        //private void btnConvert_Click(object sender, EventArgs e)
        //{
        //    string markdown = GetMarkdownTable();
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Markdown files (*.md)|*.md";
        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        File.WriteAllText(saveFileDialog.FileName, markdown);
        //    }
        //}

        //private string GetMarkdownTable()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT * FROM " + tableName;
        //        SqlCommand command = new SqlCommand(query, connection);
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //        DataTable dataTable = new DataTable();
        //        dataAdapter.Fill(dataTable);

        //        string markdown = "|";
        //        for (int i = 0; i < dataTable.Columns.Count; i++)
        //        {
        //            markdown += dataTable.Columns[i].ColumnName + "|";
        //        }
        //        markdown += "\n|";
        //        for (int i = 0; i < dataTable.Columns.Count; i++)
        //        {
        //            markdown += "---|";
        //        }
        //        markdown += "\n";
        //        foreach (DataRow row in dataTable.Rows)
        //        {
        //            markdown += "|";
        //            for (int i = 0; i < dataTable.Columns.Count; i++)
        //            {
        //                markdown += row[i].ToString() + "|";
        //            }
        //            markdown += "\n";
        //        }
        //        return markdown;
        //    }
        //}
    }
}