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
                txtFilePath.Text = filePath;
                // 将 Excel 文件加载到数据表中
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

                // 将 DataTable 转换为 Markdown
                StringBuilder markdownSb = new StringBuilder();

                markdownSb.Append("|");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    markdownSb.Append(dt.Columns[i].ColumnName + "|");
                }
                markdownSb.AppendLine(""); //换行

                markdownSb.Append("|");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    markdownSb.Append("---|");
                }
                markdownSb.AppendLine("");//换行


                foreach (DataRow row in dt.Rows)
                {
                    markdownSb.Append("|");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        markdownSb.Append(row[i].ToString() + "|");
                    }
                    markdownSb.AppendLine("");//换行
                }

                //Markdown.ToHtml(markdownSb.ToString());
                // 在 SunnyUI 控件中显示 Markdown 内容
                //txtMarkdown.HtmlRender = true;
                txtMarkdown.Text = markdownSb.ToString();
            }
        }
    }
}