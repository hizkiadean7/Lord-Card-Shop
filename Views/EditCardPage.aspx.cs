using LOrdCardShop.Controller;
using LOrdCardShop.Factory;
using LOrdCardShop.Handler;
using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class EditCardPage : System.Web.UI.Page
    {
        CardHandler cardHandler = new CardHandler();
        CardController cardController = new CardController();
        CardRepository cardRepository = new CardRepository();
        CardFactory cardFactory = new CardFactory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Card card = cardHandler.getCardUsingId(id);
                NameTb.Text = card.CardName;
                PriceTb.Text = card.CardPrice.ToString();
                DescriptionTb.Text = card.CardDesc;
                TypeTb.Text = card.CardType;
                FoilDdl.SelectedValue = card.isFoil.ToString();
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string name = NameTb.Text;
            decimal price = decimal.Parse(PriceTb.Text);
            string desc = DescriptionTb.Text;
            string type = TypeTb.Text;
            bool isFoil = FoilDdl.SelectedValue == "True";

            string errorMsg = cardHandler.updateCard(id, name, price, desc, type, isFoil);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                ErrorMsg.Text = errorMsg;
            }
            ErrorMsg.Text = "";
            Response.Redirect("ManageCardPage.aspx");
        }
    }
}