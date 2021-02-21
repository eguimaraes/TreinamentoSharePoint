using System;
using System.IO;
using System.Web;
using System.Net;
using System.Xml;
using System.Collections;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;


namespace Exemplo1.VisualWebPart1
{
    [ToolboxItemAttribute(false)]
    public partial class VisualWebPart1 : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public VisualWebPart1()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(GetRss());
           XmlNodeList list= document.GetElementsByTagName("item");

            foreach (XmlNode node  in list)
            {
                addNode(node);

            }


        }

        private void addNode(XmlNode node)
        {
            Panel panel = new Panel();
            panel.CssClass = "";
            Label label = new Label();
            label.Text = node["title"].InnerText;
            panel.Controls.Add(label);
            frameBasico.Controls.Add(panel);
        }

        private static string GetRss()
        {
            WebRequest request = WebRequest.Create("https://www.wired.com/feed/rss");
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusDescription;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            string dados = responseFromServer;
            reader.Close();
            dataStream.Close();
            response.Close();

            return dados;
        }
    }
}
