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
            this.SuspendLayout();
            // 
            // btnSelectDb
            // 
            this.btnSelectDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectDb.Location = new System.Drawing.Point(31, 47);
            this.btnSelectDb.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSelectDb.Name = "btnSelectDb";
            this.btnSelectDb.Size = new System.Drawing.Size(144, 36);
            this.btnSelectDb.TabIndex = 0;
            this.btnSelectDb.Text = "选择数据库";
            this.btnSelectDb.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSelectDb.Click += new System.EventHandler(this.btnSelectDb_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConnectionString.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConnectionString.Location = new System.Drawing.Point(182, 47);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnectionString.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Padding = new System.Windows.Forms.Padding(5);
            this.txtConnectionString.Radius = 20;
            this.txtConnectionString.ReadOnly = true;
            this.txtConnectionString.ShowText = false;
            this.txtConnectionString.Size = new System.Drawing.Size(695, 35);
            this.txtConnectionString.Style = Sunny.UI.UIStyle.Custom;
            this.txtConnectionString.StyleCustomMode = true;
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtConnectionString.Watermark = "";
            this.txtConnectionString.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnConvert
            // 
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(31, 89);
            this.btnConvert.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(144, 32);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "转换";
            this.btnConvert.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(182, 89);
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
            this.txtResult.Location = new System.Drawing.Point(4, 140);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResult.Name = "txtResult";
            this.txtResult.Padding = new System.Windows.Forms.Padding(5);
            this.txtResult.ReadOnly = true;
            this.txtResult.ShowText = false;
            this.txtResult.Size = new System.Drawing.Size(873, 357);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtResult.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(881, 513);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnSelectDb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SqlServer转Markdown";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 756, 438);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

    }
}