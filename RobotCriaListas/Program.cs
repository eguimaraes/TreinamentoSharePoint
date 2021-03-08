using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace RobotCriaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SPSite site=new SPSite(args[0]))
            {
                foreach (SPWeb web in site.AllWebs)
                {

                    web.Lists.Add(args[1], args[2], SPListTemplateType.GenericList);
                    web.Update();



                }



            }


        }
    }
}
