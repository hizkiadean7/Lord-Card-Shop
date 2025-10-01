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
    public partial class CardDetailPage : System.Web.UI.Page
    {
        CardRepository cardRepository = new CardRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGrid();
            }
        }
        public void refreshGrid()
        {
            List<Card> cards = cardRepository.getAllCards();

            if (cards != null && cards.Count > 0)
            {
                CardDetailGV.DataSource = cards;
                CardDetailGV.DataBind();
            }
            else
            {
                CardDetailGV.Visible = false;
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderCardPage.aspx");
        }
    }
}