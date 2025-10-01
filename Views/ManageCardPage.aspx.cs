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
    public partial class WebForm1 : System.Web.UI.Page
    {
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
                CardGV.DataSource = cards;
                CardGV.DataBind();
                EmptyMsg.Text = "";
                CardGV.Visible = true;
            }
            else
            {
                EmptyMsg.Text = "List is empty";
                CardGV.Visible = false;
            }
        }


        protected void CardGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = CardGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            cardHandler.deleteCard(id);
            refreshGrid();
        }

        protected void AddCardBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCardPage.aspx");
        }

        protected void CardGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = CardGV.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text;
            Response.Redirect("EditCardPage.aspx?id=" + id);
        }
    }
}
