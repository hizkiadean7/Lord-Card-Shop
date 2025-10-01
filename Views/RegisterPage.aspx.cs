using LOrdCardShop.Controller;
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
    public partial class RegisterPage : System.Web.UI.Page
    {
        UserHandler userHandler = new UserHandler();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string name = UsernameTb.Text;
            string password = PasswordTb.Text;
            string confirmPassword = ConfirmationPasswordTb.Text;
            string email = EmailTb.Text;
            string gender = GenderDdl.SelectedValue;
            string role = RoleDdl.SelectedValue;
            DateTime DOB = DateTime.Parse(DOBTb.Text);

            string error = userHandler.Register(name, password, confirmPassword, email, gender, role, DOB);
            
            if (!string.IsNullOrEmpty(error))
            {
                ErrorMsg.Text = error;
                return;
            }
            Response.Redirect("LoginPage.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}