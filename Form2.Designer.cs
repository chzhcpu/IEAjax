namespace IEAjax
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(526, 11);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage.TabIndex = 0;
            this.buttonNextPage.Text = "下一页";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(744, 250);
            this.webBrowser1.TabIndex = 1;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(27, 13);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(466, 21);
            this.textBoxURL.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 336);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(737, 249);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 597);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonNextPage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}