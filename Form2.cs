using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IEAjax
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxURL.Text = "http://59.151.93.198/Medicine/";
            webBrowser1.Navigate(textBoxURL.Text);
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            HtmlDocument hdoc=webBrowser1.Document;
            string html = hdoc.Window.Frames["sOutline"].Document.Body.InnerHtml;
            richTextBox1.Text = html;

        }
    }
}
