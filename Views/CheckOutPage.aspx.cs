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
    public partial class CheckOutPage : System.Web.UI.Page
    {
        CartHandler cartHandler = new CartHandler();
        TransactionHandler transactionHandler = new TransactionHandler();
        CardHandler cardHandler = new CardHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGrid();
            }
        }

        public void refreshGrid()
        {
            List<Cart> cartList = cartHandler.getCarts();

            List<Card> cartGvSource = new List<Card>();

            int userId = int.Parse(Request.QueryString["id"]);
            decimal totalPrice = 0;

            foreach (Cart cart in cartList)
            {

                if (userId == cart.UserID)
                {
                    Card userCard = cardHandler.getCardUsingId(cart.CardID);
                    cartGvSource.Add(userCard);
                    totalPrice += cart.Quantity * userCard.CardPrice;
                }
            }

            if (cartGvSource != null && cartGvSource.Count > 0)
            {
                CheckOutGV.DataSource = cartGvSource;
                CheckOutGV.DataBind();
            }

            TotalPriceLbl.Text = "Total price : " + totalPrice;
        }

        protected void ConfirmCheckOutBtn_Click(object sender, EventArgs e)
        {

            int userId = int.Parse(Request.QueryString["id"]);

            List<Cart> cartList = cartHandler.getCarts();
            foreach (Cart cart in cartList)
            {
                if (userId == cart.UserID)
                {
                    int transactionId = transactionHandler.createTransaction(userId);
                    transactionHandler.createDetails(transactionId, cart.CardID, cart.Quantity);
                    cartHandler.removeCart(cart);
                }
            }

            Response.Redirect("HomePage.aspx");
        }
    }
}