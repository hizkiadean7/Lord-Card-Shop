using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    User user = Session["User"] as User;
                    WelcomeLbl.Text = "Welcome " + user.UserName;
                }
                else
                {
                    WelcomeLbl.Text = "Welcome Guest";
                }
            }
        }
    }
}