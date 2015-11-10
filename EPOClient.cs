using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;


namespace IEAjax
{
    class EPOClient
    {
        public static void GetLegalStatus(string pn)
        {
            string host = "http://ops.epo.org/2.6.2/rest-services/legal/publication/epodoc/";
            string url = host + pn;
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);

            string xmlns = "xmlns:ops=\"http://ops.epo.org\" xmlns=\"http://www.epo.org/exchange\"";
            html = html.Replace("ops:", "ops-").Replace(xmlns, "");
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(html);

            XmlNodeList nodes = xdoc.SelectNodes("//ops-legal/ops-pre");
            if (nodes.Count > 0)
            {
                foreach (XmlNode node in nodes)
                {
                    XmlNode tmpnode = node;
                    System.Diagnostics.Debug.WriteLine(tmpnode.InnerText);
                    //rlt.Add(tmpnode.InnerText);
                }
            }

        }

        public static void GetPatBiblio(string pn)
        {
            string host = "http://ops.epo.org/2.6.2/rest-services/published-data/publication/epodoc/";
            string url = host + pn;
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);

            string xmlns = "xmlns:ops=\"http://ops.epo.org\" xmlns=\"http://www.epo.org/exchange\"";
            html = html.Replace("ops:", "ops-").Replace(xmlns, "");
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(html);

        }
        public static List<string> GetPatFamily(string pn)
        {
            List<string> rlt = new List<string>();

            string host = "http://ops.epo.org/2.6.2/rest-services/family/publication/epodoc/";
            string url =host+ pn;
            WebClient wc = new WebClient();
            string html=wc.DownloadString(url);
            string xmlns = "xmlns:ops=\"http://ops.epo.org\" xmlns=\"http://www.epo.org/exchange\"";
            html = html.Replace("ops:", "ops-").Replace(xmlns,"");
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(html);

            //XmlNamespaceManager xnsm = new XmlNamespaceManager(xdoc.NameTable);
            //xnsm.AddNamespace("ops", "http://ops.epo.org");
            XmlNodeList nodes = xdoc.SelectNodes("//ops-family-member/publication-reference/document-id[@document-id-type='epodoc']");
            if (nodes.Count > 0)
            {
                foreach (XmlNode node in nodes)
                {
                    XmlNode tmpnode = node.SelectSingleNode(".//doc-number");
                    System.Diagnostics.Debug.WriteLine(tmpnode.InnerText);
                    rlt.Add(tmpnode.InnerText);
                }
            }

            return rlt;
        }
    }

}
