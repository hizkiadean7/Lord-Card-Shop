using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factory
{
    public class UserFactory
    {
        public User createUser(string name, string password, string email, string gender, string role, DateTime DOB)
        {
            User user = new User();
            user.UserName = name;
            user.UserPassword = password;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserRole = role;
            user.UserDOB = DOB;
            return user;
        }
    }
}