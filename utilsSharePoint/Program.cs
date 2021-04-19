using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace utilsSharePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //acionarDevelopDashBoard();
            desligarDevelopDashBoard();

        }

        private static void DevelopDashBoardState(Microsoft.SharePoint.Administration.SPDeveloperDashboardLevel state)
        {
            SPDeveloperDashboardSettings settings =

         SPWebService.ContentService.DeveloperDashboardSettings;

            settings.DisplayLevel = SPDeveloperDashboardLevel.Off;

            settings.TraceEnabled = true;

            settings.Update();
        }

        private static void acionarDevelopDashBoard()
        {
            

            DevelopDashBoardState(SPDeveloperDashboardLevel.On);
        }

        private static void desligarDevelopDashBoard()
        {
            DevelopDashBoardState(SPDeveloperDashboardLevel.Off);
        }
    }
}
