using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System;

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Exemplo1.WebPartBasica
{
    [ToolboxItemAttribute(false)]
    public class WebPartBasica : WebPart
    {
        protected override void CreateChildControls()
        {
            var rand = new Random();
            Table tabela = new Table();

            tabela.BorderWidth = Unit.Parse("1px");
           
            TableRow row = new TableRow();
            TableCell cellData = new TableCell();
            cellData.Controls.Add(new LiteralControl("Data"));
            TableCell cellvalorEstimando = new TableCell();
            cellvalorEstimando.Controls.Add(new LiteralControl("Valor estimado"));
            TableCell cellvalorMedido = new TableCell();
            cellvalorMedido.Controls.Add(new LiteralControl("Valor Medido"));
            tabela.Rows.Add(row);

            cellData.Width = cellvalorEstimando.Width=cellvalorMedido.Width= Unit.Parse("200px");
            cellData.HorizontalAlign = cellvalorEstimando.HorizontalAlign = cellvalorMedido.HorizontalAlign =  HorizontalAlign.Center;

            row.Controls.Add(cellData);
            row.Controls.Add(cellvalorEstimando);
            row.Controls.Add(cellvalorMedido);



            NewMethod(rand,tabela,100);
            this.Controls.Add(tabela);

        }

        private static void NewMethod( Random rand,Table tabela, int nr)
        {
           for (int i = 0; i < nr; i++) { 
            
            TableRow row = new TableRow();
            TableCell cellData = new TableCell();
            cellData.Controls.Add(new LiteralControl(DateTime.Now.ToLongTimeString()));
            TableCell cellvalorEstimando = new TableCell();
            cellvalorEstimando.Controls.Add(new LiteralControl(rand.Next(100).ToString()));
            TableCell cellvalorMedido = new TableCell();
            cellvalorMedido.Controls.Add(new LiteralControl(rand.Next(100).ToString()));

                cellData.Width = cellvalorEstimando.Width = cellvalorMedido.Width = Unit.Parse("200px");
                cellData.HorizontalAlign = cellvalorEstimando.HorizontalAlign = cellvalorMedido.HorizontalAlign = HorizontalAlign.Center;

                row.Controls.Add(cellData);
             row.Controls.Add(cellvalorEstimando);
             row.Controls.Add(cellvalorMedido);

             tabela.Rows.Add(row);


            }
        }


    }
}
