using LOrdCardShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repository
{
    public class UserRepository
    {
        DatabaseEntities2 db = new DatabaseEntities2();
        public void insertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User getUserByUsername(string username)
        {
            User user = db.Users.FirstOrDefault(u => u.UserName == username);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public void updateProfile(User user, User updatedUser)
        {
            User temp = db.Users.Find(user.UserID);
            if (temp != null)
            {
                temp.UserName = updatedUser.UserName;
                temp.UserPassword = updatedUser.UserPassword;
                temp.UserEmail = updatedUser.UserEmail;
                temp.UserGender = updatedUser.UserGender;
                temp.UserDOB = updatedUser.UserDOB;
            }
            db.SaveChanges();
        }

        public User getUserByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.UserEmail == email);
        }
    }
}