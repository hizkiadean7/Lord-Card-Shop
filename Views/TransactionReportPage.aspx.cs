using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrdCardShop.Dataset;
using LOrdCardShop.Handler;
using LOrdCardShop.Models;
using LOrdCardShop.Reporting;

namespace LOrdCardShop.Views
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        TransactionHandler transactionHandler = new TransactionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;

            DataSet1 data = getData(transactionHandler.getTransactionHeaders().ToList());
            report.SetDataSource(data);
        }

        private DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            int grandTotal = 0;

            foreach(TransactionHeader th in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = th.TransactionID;
                hrow["TransactionDate"] = th.TransactionDate;
                hrow["CustomerID"] = th.CustomerID;
                hrow["Status"] = th.Status;


                foreach (Models.TransactionDetail td in th.TransactionDetails)
                {

                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = td.TransactionID;
                    drow["CardID"] = td.CardID;
                    drow["Quantity"] = td.Quantity;

                    int detailSubTotal = (int)(td.Quantity * td.Card.CardPrice);

                    grandTotal += detailSubTotal;
                    drow["SubTotal"] = detailSubTotal;
                    detailTable.Rows.Add(drow);
                }
                hrow["GrandTotal"] = grandTotal;
                headerTable.Rows.Add(hrow);
            }
            return data;
        }
    }
}