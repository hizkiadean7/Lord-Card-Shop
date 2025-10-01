using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOrdCardShop.Views
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CustomerNav.Visible = false;
                AdminNav.Visible = false;
                GuestNav.Visible = false;

                User user = Session["User"] as User;
                if (user != null)
                {
                    RoleLbl.Text = user.UserRole.ToString();

                    string role = user.UserRole.ToString();

                    if (role == "Customer")
                    {
                        CustomerNav.Visible = true;
                        OrderCardLink.NavigateUrl = "OrderCardPage.aspx?id=" + user.UserID;
                        CartPageLink.NavigateUrl = "CartPage.aspx?id=" + user.UserID;
                    }

                    if (role == "Admin")
                    {
                        AdminNav.Visible = true;

                    }
                }
                else
                {
                    RoleLbl.Text = "Guest";
                    GuestNav.Visible = true;
                }
            }
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            string role = user.UserRole ?? "Guest";
            string key = SearchBox.Text.Trim();
            if (role == "Admin")
            {
                Response.Redirect($"ManageCardPage.aspx?search={Server.UrlEncode(key)}");
            }
            else{
                Response.Redirect($"OrderCardPage.aspx?search={Server.UrlEncode(key)}");
            }
        }
    }
}