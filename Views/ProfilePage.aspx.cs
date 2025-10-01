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
    public partial class Profile : System.Web.UI.Page
    {
        UserHandler userHandler = new UserHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User user = Session["User"] as User;
                
                UsernameTb.Text = user.UserName;
                EmailTb.Text = user.UserEmail;
                GenderDdl.SelectedValue = user.UserGender;
                DOBTb.Text = user.UserDOB.ToString("yyyy-MM-dd");
            }
        }

        protected void ChangeProfileBtn_Click(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            string username = UsernameTb.Text;
            string email = EmailTb.Text;
            string oldPassword = OldPasswordTb.Text;
            string password = NewPasswordTb.Text;
            string confirmationPassword = ConfirmationPasswordTb.Text;
            string gender = GenderDdl.SelectedValue;
            string dob = DOBTb.Text;

            string result = userHandler.UpdateProfile(user, username, oldPassword, password, confirmationPassword, email, gender, dob, user.UserPassword);

            if (string.IsNullOrEmpty(result))
            {
                Session["User"] = userHandler.getUserByUsername(username);
                Response.Redirect(Request.RawUrl);

            }
            else
            {
                ErrorMsg.Text = result;
            }
        }
    }
}