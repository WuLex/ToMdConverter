using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;

namespace test
{
    public partial class ExcelToMdForm : Sunny.UI.UIForm
    {
        public ExcelToMdForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Load Excel file into a DataTable
                DataTable dt = new DataTable();
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        dt = result.Tables[0];
                    }
                }

                // Convert DataTable to Markdown
                string markdown = "|";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    markdown += dt.Columns[i].ColumnName + "|";
                }
                markdown += "\n|";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    markdown += "---|";
                }
                markdown += "\n";
                foreach (DataRow row in dt.Rows)
                {
                    markdown += "|";
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        markdown += row[i].ToString() + "|";
                    }
                    markdown += "\n";
                }
                markdown = Markdown.ToHtml(markdown);

                // Display Markdown content in SunnyUI control
                //txtMarkdown.HtmlRender = true;
                txtMarkdown.Text = markdown;
            }
        }
    }
}