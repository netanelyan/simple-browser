
namespace WebBrowser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.search_btn = new System.Windows.Forms.Button();
            this.userinput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.github_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.browser_browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(12, 12);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(93, 15);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(820, 20);
            this.userinput.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // github_btn
            // 
            this.github_btn.Location = new System.Drawing.Point(999, 15);
            this.github_btn.Name = "github_btn";
            this.github_btn.Size = new System.Drawing.Size(75, 23);
            this.github_btn.TabIndex = 3;
            this.github_btn.Text = "GITHUB";
            this.github_btn.UseVisualStyleBackColor = true;
            this.github_btn.Click += new System.EventHandler(this.github_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(919, 15);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "REFRESH";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // browser_browser
            // 
            this.browser_browser.Location = new System.Drawing.Point(12, 56);
            this.browser_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser_browser.Name = "browser_browser";
            this.browser_browser.Size = new System.Drawing.Size(1062, 597);
            this.browser_browser.TabIndex = 4;
            this.browser_browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 665);
            this.Controls.Add(this.browser_browser);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.github_btn);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.search_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button github_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.WebBrowser browser_browser;
    }
}

