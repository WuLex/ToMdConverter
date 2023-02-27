using System;

namespace test
{
    partial class DbToMdForm
    {
        private Sunny.UI.UIButton btnSelectDb;
        private Sunny.UI.UITextBox txtConnectionString;
        private Sunny.UI.UIButton btnConvert;
        private Sunny.UI.UILabel lblStatus;
        private Sunny.UI.UIRichTextBox txtResult;

        

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelectDb = new Sunny.UI.UIButton();
            this.txtConnectionString = new Sunny.UI.UITextBox();
            this.btnConvert = new Sunny.UI.UIButton();
            this.lblStatus = new Sunny.UI.UILabel();
            this.txtResult = new Sunny.UI.UIRichTextBox();
            this.txtTableResult = new Sunny.UI.UIRichTextBox();
            this.btnConvertTbData = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.cbTbList = new Sunny.UI.UIComboBox();
            this.lblselectTb = new Sunny.UI.UILabel();
            this.txtTableSchemaResult = new Sunny.UI.UIRichTextBox();
            this.btnConvertTbSchema = new Sunny.UI.UIButton();
            this.cbTableList = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // btnSelectDb
            // 
            this.btnSelectDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectDb.Location = new System.Drawing.Point(31, 48);
            this.btnSelectDb.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectDb.Name = "btnSelectDb";
            this.btnSelectDb.Size = new System.Drawing.Size(166, 48);
            this.btnSelectDb.TabIndex = 0;
            this.btnSelectDb.Text = "选择数据库";
            this.btnSelectDb.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSelectDb.Click += new System.EventHandler(this.btnSelectDb_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConnectionString.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnectionString.Location = new System.Drawing.Point(204, 47);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnectionString.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Padding = new System.Windows.Forms.Padding(5);
            this.txtConnectionString.Radius = 20;
            this.txtConnectionString.ShowText = false;
            this.txtConnectionString.Size = new System.Drawing.Size(856, 49);
            this.txtConnectionString.Style = Sunny.UI.UIStyle.Custom;
            this.txtConnectionString.StyleCustomMode = true;
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtConnectionString.Watermark = "";
            this.txtConnectionString.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtConnectionString.TextChanged += new System.EventHandler(this.txtConnectionString_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(31, 181);
            this.btnConvert.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(257, 51);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "转换数据库表信息到Md";
            this.btnConvert.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(31, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(633, 32);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "未选择数据库";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtResult
            // 
            this.txtResult.FillColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(4, 242);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResult.Name = "txtResult";
            this.txtResult.Padding = new System.Windows.Forms.Padding(5);
            this.txtResult.ReadOnly = true;
            this.txtResult.ShowText = false;
            this.txtResult.Size = new System.Drawing.Size(449, 370);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtResult.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTableResult
            // 
            this.txtTableResult.FillColor = System.Drawing.Color.White;
            this.txtTableResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTableResult.Location = new System.Drawing.Point(461, 242);
            this.txtTableResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTableResult.Name = "txtTableResult";
            this.txtTableResult.Padding = new System.Windows.Forms.Padding(2);
            this.txtTableResult.ShowText = false;
            this.txtTableResult.Size = new System.Drawing.Size(486, 365);
            this.txtTableResult.TabIndex = 5;
            this.txtTableResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTableResult.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnConvertTbData
            // 
            this.btnConvertTbData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertTbData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertTbData.Location = new System.Drawing.Point(755, 183);
            this.btnConvertTbData.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConvertTbData.Name = "btnConvertTbData";
            this.btnConvertTbData.Size = new System.Drawing.Size(192, 51);
            this.btnConvertTbData.TabIndex = 6;
            this.btnConvertTbData.Text = "转换表数据到Md";
            this.btnConvertTbData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnConvertTbData.Click += new System.EventHandler(this.btnConvertTbData_ClickAsync);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine1.Location = new System.Drawing.Point(3, 137);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(1532, 36);
            this.uiLine1.TabIndex = 7;
            this.uiLine1.Text = "区分";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbTbList
            // 
            this.cbTbList.DataSource = null;
            this.cbTbList.FillColor = System.Drawing.Color.White;
            this.cbTbList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTbList.Location = new System.Drawing.Point(547, 181);
            this.cbTbList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTbList.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTbList.Name = "cbTbList";
            this.cbTbList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTbList.Size = new System.Drawing.Size(201, 51);
            this.cbTbList.TabIndex = 8;
            this.cbTbList.Text = "-请选择表-";
            this.cbTbList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTbList.Watermark = "";
            this.cbTbList.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lblselectTb
            // 
            this.lblselectTb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblselectTb.Location = new System.Drawing.Point(461, 181);
            this.lblselectTb.Name = "lblselectTb";
            this.lblselectTb.Size = new System.Drawing.Size(79, 51);
            this.lblselectTb.TabIndex = 9;
            this.lblselectTb.Text = "选择表:";
            this.lblselectTb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblselectTb.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTableSchemaResult
            // 
            this.txtTableSchemaResult.FillColor = System.Drawing.Color.White;
            this.txtTableSchemaResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTableSchemaResult.Location = new System.Drawing.Point(955, 242);
            this.txtTableSchemaResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableSchemaResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTableSchemaResult.Name = "txtTableSchemaResult";
            this.txtTableSchemaResult.Padding = new System.Windows.Forms.Padding(2);
            this.txtTableSchemaResult.ShowText = false;
            this.txtTableSchemaResult.Size = new System.Drawing.Size(522, 365);
            this.txtTableSchemaResult.TabIndex = 6;
            this.txtTableSchemaResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTableSchemaResult.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnConvertTbSchema
            // 
            this.btnConvertTbSchema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertTbSchema.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertTbSchema.Location = new System.Drawing.Point(1267, 179);
            this.btnConvertTbSchema.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConvertTbSchema.Name = "btnConvertTbSchema";
            this.btnConvertTbSchema.Size = new System.Drawing.Size(179, 51);
            this.btnConvertTbSchema.TabIndex = 10;
            this.btnConvertTbSchema.Text = "转换表结构到Md";
            this.btnConvertTbSchema.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnConvertTbSchema.Click += new System.EventHandler(this.btnConvertTbSchema_ClickAsync);
            // 
            // cbTableList
            // 
            this.cbTableList.DataSource = null;
            this.cbTableList.FillColor = System.Drawing.Color.White;
            this.cbTableList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTableList.Location = new System.Drawing.Point(1041, 181);
            this.cbTableList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTableList.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTableList.Name = "cbTableList";
            this.cbTableList.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTableList.Size = new System.Drawing.Size(201, 51);
            this.cbTableList.TabIndex = 9;
            this.cbTableList.Text = "-请选择表-";
            this.cbTableList.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTableList.Watermark = "";
            this.cbTableList.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(955, 183);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(79, 51);
            this.uiLabel1.TabIndex = 11;
            this.uiLabel1.Text = "选择表:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DbToMdForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1492, 612);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.cbTableList);
            this.Controls.Add(this.btnConvertTbSchema);
            this.Controls.Add(this.txtTableSchemaResult);
            this.Controls.Add(this.lblselectTb);
            this.Controls.Add(this.cbTbList);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnConvertTbData);
            this.Controls.Add(this.txtTableResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnSelectDb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DbToMdForm";
            this.Text = "SqlServer转Markdown";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 756, 438);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private Sunny.UI.UIRichTextBox txtTableResult;
        private Sunny.UI.UIButton btnConvertTbSchema;
        private Sunny.UI.UILine uiLine1;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.Button button1;
        private Sunny.UI.UIComboBox cbTbList;
        private Sunny.UI.UILabel lblselectTb;
        private Sunny.UI.UIButton btnConvertTbData;
        private Sunny.UI.UIRichTextBox txtTableSchemaResult;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox cbTableList;
        private Sunny.UI.UILabel uiLabel1;
    }
}