namespace test
{
    partial class ExcelToMdForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarkdown = new Sunny.UI.UITextBox();
            this.btnOpen = new Sunny.UI.UIButton();
            this.btnClose = new Sunny.UI.UIButton();
            this.txtFilePath = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // txtMarkdown
            // 
            this.txtMarkdown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarkdown.Location = new System.Drawing.Point(16, 116);
            this.txtMarkdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMarkdown.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMarkdown.Multiline = true;
            this.txtMarkdown.Name = "txtMarkdown";
            this.txtMarkdown.Padding = new System.Windows.Forms.Padding(6);
            this.txtMarkdown.ShowText = false;
            this.txtMarkdown.Size = new System.Drawing.Size(608, 393);
            this.txtMarkdown.TabIndex = 0;
            this.txtMarkdown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMarkdown.Watermark = "";
            this.txtMarkdown.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(652, 67);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(176, 44);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开Excel文件";
            this.btnOpen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(652, 198);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "无用按钮";
            this.btnClose.Visible = false;
            this.btnClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilePath.Location = new System.Drawing.Point(134, 67);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ShowText = false;
            this.txtFilePath.Size = new System.Drawing.Size(490, 44);
            this.txtFilePath.TabIndex = 3;
            this.txtFilePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFilePath.Watermark = "";
            this.txtFilePath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(4, 71);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(123, 36);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "Excel路径：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ExcelToMdForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 529);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtMarkdown);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcelToMdForm";
            this.Text = "Excel to Markdown";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 900, 529);
            this.ResumeLayout(false);

        }
        private Sunny.UI.UITextBox txtMarkdown;
        private Sunny.UI.UIButton btnOpen;
        #endregion

        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UITextBox txtFilePath;
        private Sunny.UI.UILabel uiLabel1;
    }
}