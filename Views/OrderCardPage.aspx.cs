using LOrdCardShop.Handler;
using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class OrderCardPage : System.Web.UI.Page
    {
        CartHandler cartHandler = new CartHandler();
        CardHandler cardHandler = new CardHandler();
        UserHandler userHandler = new UserHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGrid();
            }
        }

        public void refreshGrid()
        {
            string searchKey = Request.QueryString["search"];
            List<Card> cards = cardHandler.getCards();

            if (!string.IsNullOrEmpty(searchKey))
            {
                searchKey = searchKey.ToLower();
                cards = cards.Where(card =>
                    card.CardName.ToLower().Contains(searchKey)).ToList();
            }

            if (cards != null && cards.Count > 0)
            {
                OrderCardGV.DataSource = cards;
                OrderCardGV.DataBind();
            }
            else
            {
                EmptyMsg.Text = "No cards found.";
                OrderCardGV.Visible = false;
            }

        }

        protected void DetailBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CardDetailPage.aspx");
        }

        protected void OrderCardGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = OrderCardGV.Rows[rowIndex];

                int cardId = int.Parse(row.Cells[0].Text);
                TextBox quantityTb = (TextBox)row.FindControl("QuantityTb");
                int quantity = int.Parse(quantityTb.Text);
                int userId = int.Parse(Request.QueryString["id"]);
                cartHandler.addToCart(cardId, userId, quantity);
            }
        }
    }
}