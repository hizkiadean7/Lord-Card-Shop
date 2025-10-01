using LOrdCardShop.Factory;
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
    public partial class AddCardPage : System.Web.UI.Page
    {
        CardHandler cardHandler = new CardHandler();
        CardRepository cardRepository = new CardRepository();
        CardFactory cardFactory = new CardFactory();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            decimal price = decimal.Parse(PriceTb.Text);
            string desc = DescriptionTb.Text;
            string type = TypeTb.Text;
            bool isFoil = FoilDdl.SelectedValue == "True";

            string error = cardHandler.addCard(name, price, desc, type, isFoil);

            if (!string.IsNullOrEmpty(error))
            {
                ErrorMsg.Text = error;
                return;
            }
            ErrorMsg.Text = "";

            Response.Redirect("ManageCardPage.aspx");
        }
    }
}