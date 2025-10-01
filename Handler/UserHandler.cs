using LOrdCardShop.Controller;
using LOrdCardShop.Factory;
using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handler
{
    public class UserHandler
    {
        UserController userController = new UserController();
        UserFactory userFactory = new UserFactory();

        public string Register(string name, string password, string confirmPassword, string email, string gender, string role, DateTime DOB)
        {
            string error = userController.validateRegister(name, password, confirmPassword, email, gender, role, DOB);
            
            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }
            
            User user = userFactory.createUser(name, password, email, gender, role, DOB);

            userController.registerUser(user);

            return "";
        }

        public string Login(string name, string password)
        {
            return userController.validateLogin(name, password);
        }

        public User getUserByUsername(string username)
        {
            return userController.getUserByUsername(username);
        }

        public string UpdateProfile(User user, string name, string oldPassword, string password, string confirmPassword, string email, string gender, string DOB, string realPassword)
        {
            string error = userController.validateUpdateProfile(user, name, oldPassword, password, confirmPassword, email, gender, DateTime.Parse(DOB));

            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }

            if (string.IsNullOrEmpty(oldPassword))
            {
                password = realPassword;
            }

            User updatedUser = userFactory.createUser(name, password, email, gender, user.UserRole, DateTime.Parse(DOB));
            userController.updateProfile(user, updatedUser);
            return "";
        }
    }
}