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
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        CardHandler cardHandler = new CardHandler();
        TransactionHandler transactionHandler = new TransactionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Models.User user = (Models.User)Session["User"];
                refreshGrid(int.Parse(Request.QueryString["id"]));
            }
        }

        public void refreshGrid(int id)
        {
            List<TransactionHeader> transaction = transactionHandler.getTransaction(id);

            List<Card> cardList = new List<Card>();

            List<TransactionDetail> details = transactionHandler.getTransactionDetail(id);

            foreach (TransactionDetail detail in details)
            {
                Card card = cardHandler.getCardUsingId(detail.CardID);
                if (card != null)
                {
                    cardList.Add(card);
                }
            }

            DetailGV.DataSource = transaction;
            DetailGV.DataBind();

            CardGV.DataSource = cardList;
            CardGV.DataBind();
        }
    }
}