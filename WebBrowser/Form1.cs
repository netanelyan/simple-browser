using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Simple WebBrowser | By ItsBlackZlol";
            this.Size = new Size(1102, 704);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            browser_browser.Refresh();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            browser_browser.Navigate(userinput.Text);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            browser_browser.Navigate("www.github.com/ItsBlackZlol");
            userinput.Text = "www.github.com/ItsBlackZlol"; 

        }

        private void github_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
