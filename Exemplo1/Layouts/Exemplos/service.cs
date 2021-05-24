using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using Microsoft.SharePoint;


namespace Exemplo1.Layouts.Exemplos
{
    class service
    {
        [WebMethod]
        public string GetSiteListCount()
        {
            var web = SPContext.Current.Web;
            return (web.Title + " contains " + web.Lists.Count.ToString() + " lists.");
        }
    }
}

