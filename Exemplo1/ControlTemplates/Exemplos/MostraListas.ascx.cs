using System;
using Microsoft.SharePoint;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Exemplo1.ControlTemplates.Exemplos
{
    public partial class MostraListas : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            foreach (SPList list in SPContext.Current.Web.Lists)
            {

                string htmltemplate="<div class=\"card\" style=\"width: 18rem;\">"+
  "<img class=\"card-img-top\" src=\"...\" alt=\"Card image cap\">"+
  "<div class=\"card-body\">"+
    "<h5 class=\"card-title\">"+list.Title+"</h5>" +
                    "<p class=\"card-text\">Exemplo para listas.</p>" +
                    "<a href = \"#\" class=\"btn btn-primary\">Ver a lista</a>" +
                    "</div></div>";

                  Painel.Controls.Add(new LiteralControl("htmltemplate"));



            }


        }
    }
}
