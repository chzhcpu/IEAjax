using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace IEAjax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxURL.Text = "http://v3.espacenet.com/publicationDetails/inpadoc?CC=CN&NR=101433645A&KC=A&FT=D&date=20090520&DB=EPODOC&locale=en_gb";
            ////////////http://worldwide.espacenet.com/publicationDetails/inpadoc?CC=CN&NR=101433645A&KC=A&FT=D&date=20090520&DB=EPODOC&locale=en_EP
            //textBoxURL.Text = "http://pharma.vicp.net/Login.aspx";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
                return;
            webBrowser1.Navigate(url);
            
        }

        private void buttonShowDocText_Click(object sender, EventArgs e)
        {
            string html = webBrowser1.Document.Body.InnerHtml;
            //richTextBox1.Text = html;
            PrintDomBegin();
            //string pn = "JP2010031006";

            
            //patentEntities pe = new patentEntities();
            /*var q=from b in pe.epo_biblio
                  orderby b.pn
                  select b;*/
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            HtmlElement divtag = webBrowser1.Document.GetElementById("loadingDiv");
            if (divtag != null)
            {
                divtag.AttachEventHandler("onpropertychange",new EventHandler(handler));
            }
            string html = divtag.InnerHtml;
            richTextBox1.Text = html;
            
            //richTextBox1.Text = webBrowser1.DocumentText;HtmlElement 

            divtag = webBrowser1.Document.GetElementById("form1");
            if (divtag != null)
            {
                divtag.AttachEventHandler("onpropertychange", new EventHandler(handler));
            }
        }

        private void handler(Object sender, EventArgs e)
        {
            HtmlElement div = webBrowser1.Document.GetElementById("loadingDiv");
            if (div == null) return;

            String x = div.InnerHtml; // etc
            string text = div.InnerText;

            if (!string.IsNullOrEmpty(text))
            {
                // Now the element has been populated, do something
                richTextBox1.Text = x;
            }

        }


        private void PrintDomBegin()
        {
            if (webBrowser1.Document != null)
            {
                HtmlElementCollection elemColl = null;
                HtmlDocument doc = webBrowser1.Document;
                if (doc != null)
                {
                    elemColl = doc.GetElementsByTagName("HTML");
                    String str = PrintDom(elemColl, new System.Text.StringBuilder(), 0);
                    //webBrowser1.DocumentText = str;
                    richTextBox1.Text = str;
                }
            }
        }

        private string PrintDom(HtmlElementCollection elemColl, System.Text.StringBuilder returnStr, Int32 depth)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();

            foreach (HtmlElement elem in elemColl)
            {
                string elemName;

                elemName = elem.GetAttribute("ID");
                if (elemName == null || elemName.Length == 0)
                {
                    elemName = elem.GetAttribute("name");
                    if (elemName == null || elemName.Length == 0)
                    {
                        elemName = "<no name>";
                    }
                }

                str.Append(' ', depth * 4);
                str.Append(elemName + ": " + elem.TagName + "(Level " + depth + ")");
                returnStr.AppendLine(str.ToString());

                if (elem.CanHaveChildren)
                {
                    PrintDom(elem.Children, returnStr, depth + 1);
                }

                str.Remove(0, str.Length);
            }

            return (returnStr.ToString());
        }


    }
}
