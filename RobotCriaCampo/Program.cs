using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace RobotCriaCampo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (SPSite site=new SPSite(args[0]))
            {

                foreach (SPWeb web in site.AllWebs)
                {


                   Guid listId= web.Lists.Add(args[1], args[2], SPListTemplateType.GenericList);

                    web.Update();

                    SPList lista = web.Lists[listId];

                    lista.Fields.AddFieldAsXml(args[3]);

                    lista.Update();


                }



            }


        }
    }
}
