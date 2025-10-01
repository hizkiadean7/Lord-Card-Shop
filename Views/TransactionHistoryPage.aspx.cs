using LOrdCardShop.Handler;
using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace LOrdCardShop.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        TransactionHandler transactionHandler = new TransactionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Models.User user = (Models.User)Session["User"];
                if (user.UserRole == "Customer")
                {
                    refreshGridCustomer();
                }
                else if (user.UserRole == "Admin")
                {
                    refreshGrid();
                }
            }
        }

        public void refreshGridCustomer()
        {
            Models.User user = (Models.User)Session["User"];
            int id = user.UserID;
            List<TransactionHeader> transaction = transactionHandler.getTransactionByCustId(id);
            TransactionGV.DataSource = transaction;
            TransactionGV.DataBind();
        }
        public void refreshGrid()
        {
            List<TransactionHeader> transactionHeaders = transactionHandler.getTransactionHeaders();
            if (transactionHeaders != null && transactionHeaders.Count > 0)
            {
                TransactionGV.DataSource = transactionHeaders;
                TransactionGV.DataBind();
                EmptyMsg.Text = "";
            }
            else
            {
                EmptyMsg.Text = "List is empty";
                TransactionGV.Visible = false;
            }
        }

        protected void TransactionGV_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = TransactionGV.Rows[e.NewSelectedIndex];
            int id = int.Parse(row.Cells[0].Text);
            Response.Redirect("DetailTransactionPage.aspx?id=" + id);
        }
    }
}