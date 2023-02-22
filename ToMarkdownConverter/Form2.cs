using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SqlTableToMarkdown
{
    public partial class Form2 : Form
    {
        private readonly string _filePath = "C:\\myExcelFile.xlsx";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var markdown = GetMarkdownTable();
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Markdown files (*.md)|*.md"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, markdown);
            }
        }

        private string GetMarkdownTable()
        {
            using var stream = File.Open(_filePath, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            var dataSet = reader.AsDataSet();
            var table = dataSet.Tables[0];

            var markdown = $"|{string.Join("|", table.Columns.Cast<DataColumn>().Select(c => c.ColumnName))}|\n" +
                           $"|{string.Join("|", table.Columns.Cast<DataColumn>().Select(c => "---"))}|\n";
            foreach (DataRow row in table.Rows)
            {
                markdown += $"|{string.Join("|", row.ItemArray)}|\n";
            }
            return markdown;
        }
    }
}



//using ExcelDataReader;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SqlTableToMarkdown
//{
//    public partial class Form2 : Form
//    {
//        public Form2()
//        {
//            InitializeComponent();


//        }

//        private string filePath = "C:\\myExcelFile.xlsx";

//        private void btnConvert_Click(object sender, EventArgs e)
//        {
//            string markdown = GetMarkdownTable();
//            SaveFileDialog saveFileDialog = new SaveFileDialog();
//            saveFileDialog.Filter = "Markdown files (*.md)|*.md";
//            if (saveFileDialog.ShowDialog() == DialogResult.OK)
//            {
//                File.WriteAllText(saveFileDialog.FileName, markdown);
//            }
//        }

//        private string GetMarkdownTable()
//        {
//            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
//            {
//                using (var reader = ExcelReaderFactory.CreateReader(stream))
//                {
//                    var dataSet = reader.AsDataSet();
//                    var table = dataSet.Tables[0];

//                    string markdown = "|";
//                    for (int i = 0; i < table.Columns.Count; i++)
//                    {
//                        markdown += table.Columns[i].ColumnName + "|";
//                    }
//                    markdown += "\n|";
//                    for (int i = 0; i < table.Columns.Count; i++)
//                    {
//                        markdown += "---|";
//                    }
//                    markdown += "\n";
//                    foreach (DataRow row in table.Rows)
//                    {
//                        markdown += "|";
//                        for (int i = 0; i < table.Columns.Count; i++)
//                        {
//                            markdown += row[i].ToString() + "|";
//                        }
//                        markdown += "\n";
//                    }
//                    return markdown;
//                }
//            }
//        }

//    }


//}

