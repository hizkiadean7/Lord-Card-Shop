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
    public partial class CartPage : System.Web.UI.Page
    {
        CartHandler cartHandler = new CartHandler();
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

            foreach (Cart cart in cartList){
                
               if (userId == cart.UserID)
               {
                    Card userCard = cardHandler.getCardUsingId(cart.CardID);
                    cartGvSource.Add(userCard);
               }
            }

            if (cartGvSource != null && cartGvSource.Count > 0)
            {
                CartGV.DataSource = cartGvSource;
                CartGV.DataBind();
            }
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(Request.QueryString["id"]);
            Response.Redirect("CheckOutPage.aspx?id=" + userId);
        }
    }
}