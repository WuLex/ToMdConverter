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
            this.SuspendLayout();
            // 
            // txtMarkdown
            // 
            this.txtMarkdown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarkdown.Location = new System.Drawing.Point(4, 180);
            this.txtMarkdown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMarkdown.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMarkdown.Multiline = true;
            this.txtMarkdown.Name = "txtMarkdown";
            this.txtMarkdown.Padding = new System.Windows.Forms.Padding(6);
            this.txtMarkdown.ShowText = false;
            this.txtMarkdown.Size = new System.Drawing.Size(892, 329);
            this.txtMarkdown.TabIndex = 0;
            this.txtMarkdown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMarkdown.Watermark = "";
            this.txtMarkdown.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(652, 53);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(176, 44);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开";
            this.btnOpen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(652, 107);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "无用按钮";
            this.btnClose.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtMarkdown);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Excel to Markdown";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 900, 529);
            this.ResumeLayout(false);

        }
        private Sunny.UI.UITextBox txtMarkdown;
        private Sunny.UI.UIButton btnOpen;
        #endregion

        private Sunny.UI.UIButton btnClose;
    }
}