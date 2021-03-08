using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace RobotListas
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SPSite site = new SPSite(args[0]))
            {

                using (SPWeb web = site.AllWebs[args[1]])
                {

                    SPListCollection listas = web.Lists;

                    foreach (SPList lista in listas)
                    {
                        

                        Console.WriteLine(lista.Title);


                    }



                }



            }

        }


    }
}