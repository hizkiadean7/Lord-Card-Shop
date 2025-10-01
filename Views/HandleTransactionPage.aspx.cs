using LOrdCardShop.Handler;
using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class HandleTransaction : System.Web.UI.Page
    {
        TransactionHandler transactionHandler = new TransactionHandler();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGrid();
            }
        }

        public void refreshGrid()
        {
            List<TransactionHeader> allTransactions = transactionHandler.getTransactionHeaders();

            List<TransactionHeader> unhandled = allTransactions.Where(t => t.Status == "Unhandled").ToList();
            List<TransactionHeader> handled = allTransactions.Where(t => t.Status == "Handled").ToList();

            UnhandledGV.DataSource = unhandled;
            UnhandledGV.DataBind();

            HandledGV.DataSource = handled;
            HandledGV.DataBind();
        }

        protected void UnhandledGV_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = UnhandledGV.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            transactionHandler.handleTransaction(id);
            refreshGrid();
        }
    }
}