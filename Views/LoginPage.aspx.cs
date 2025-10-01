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
    public partial class LoginPage : System.Web.UI.Page
    {
        UserHandler userHandler = new UserHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["RememberMe"] != null)
                {
                    string rememberedUsername = Request.Cookies["RememberMe"].Value;
                    UsernameTb.Text = rememberedUsername;
                    RememberMeCB.Checked = true;
                }
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;
            
            string error = userHandler.Login(username, password);

            if (!string.IsNullOrEmpty(error))
            {
                ErrorMsg.Text = error;
                return;
            }

            User user = userHandler.getUserByUsername(username);

            Session["User"] = user;

            if (RememberMeCB.Checked)
            {
                HttpCookie cookie = new HttpCookie("RememberMe", username);
                cookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(cookie);
            }
            else
            {
                if (Request.Cookies["RememberMe"] != null)
                {
                    HttpCookie cookie = new HttpCookie("RememberMe");
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    cookie.Value = "";
                    Response.Cookies.Add(cookie);
                }
            }

            Response.Redirect("HomePage.aspx");

        }
    }
}