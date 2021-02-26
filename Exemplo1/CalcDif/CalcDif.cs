using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System;
using System.Security.Permissions;

namespace Exemplo1.CalcDif
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class CalcDif : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {

            properties.ListItem["Title"] = DateTime.Now.ToLongDateString() + " : " + DateTime.Now.ToLongTimeString();
            properties.ListItem["Diferenca"] = Convert.ToDouble(properties.ListItem["ValorMedido"]) - Convert.ToDouble(properties.ListItem["ValorEsperado"]);
            properties.ListItem.Update();
            base.ItemAdded(properties);




        }

        /// <summary>
        /// An item was updated.
        /// </summary>
        public override void ItemUpdated(SPItemEventProperties properties)
        {
            base.ItemUpdated(properties);
        }


    }
}