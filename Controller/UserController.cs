using LOrdCardShop.Models;
using LOrdCardShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace LOrdCardShop.Controller
{
    public class UserController
    {
        UserRepository userRepository = new UserRepository();

        public string validateRegister(string name, string password, string confirmPassword, string email, string gender, string role, DateTime DOB)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 5 || name.Length > 30)
            {
                return "Username must be between 5 and 30 characters";
            }

            if (!name.All(c => char.IsLetter(c) || c == ' '))
            {
                return "Username must contain only letters and spaces";
            }

            if (string.IsNullOrEmpty(email))
            {
                return "Email must be filled";
            }

            if (!email.Contains("@"))
            {
                return "Email must contain @";
            }

            if (userRepository.getUserByEmail(email) != null)
            {
                return "Email is already registered";
            }


            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return "Password must be longer than 8 characters";
            }

            if (!password.All(c => char.IsLetterOrDigit(c)))
            {
                return "Password must be alphanumeric";
            }

            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                return "Password must contain at least one character or one digit";
            }

            if (confirmPassword != password)
            {
                return "Password and confirmation password must match";
            }

            if (DOB > DateTime.Now)
            {
                return "Birthdate cannot be in the future";
            }

            if (string.IsNullOrEmpty(gender))
            {
                return "Gender must be filled";
            }

            if (string.IsNullOrEmpty(role))
            {
                return "Role must be filled";
            }
            return "";
        }

        public void registerUser(User user)
        {
            userRepository.insertUser(user);
        }

        public string validateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Username must be filled";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "Password must be filled";
            }

            User user = userRepository.getUserByUsername(username);

            if (user == null)
            {
                return  "Invalid username";
            }

            if (user.UserPassword != password)
            {
                return "Invalid password";
            }

            return "";
        }

        public string validateUpdateProfile(User user, string name, string oldPassword, string password, string confirmPassword, string email, string gender, DateTime DOB) 
        {
            if (string.IsNullOrEmpty(name) || name.Length < 5 || name.Length > 30)
            {
                return "Username must be between 5 and 30 characters";
            }

            if (!name.All(c => char.IsLetter(c) || c == ' '))
            {
                return "Username must contain only letters and spaces";
            }

            if (string.IsNullOrEmpty(email))
            {
                return "Email must be filled";
            }

            if (!email.Contains("@"))
            {
                return "Email must contain @";
            }

            if (userRepository.getUserByEmail(email) != null)
            {
                return "Email is already registered";
            }


            if (!string.IsNullOrEmpty(oldPassword))
            {
                if (oldPassword != user.UserPassword)
                {
                    return "Old password doesn't match";
                }
                if (string.IsNullOrEmpty(password) || password.Length < 8)
                {
                    return "Password must be longer than 8 characters";
                }

                if (!password.All(c => char.IsLetterOrDigit(c)))
                {
                    return "Password must be alphanumeric";
                }

                if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
                {
                    return "Password must contain at least one character or one digit";
                }

                if (confirmPassword != password)
                {
                    return "Password and confirmation password must match";
                }
            }

            if (DOB > DateTime.Now)
            {
                return "Birthdate cannot be in the future";
            }

            if (string.IsNullOrEmpty(gender))
            {
                return "Gender must be filled";
            }

            return "";
        }

        public void updateProfile(User user, User updatedUser)
        {
            userRepository.updateProfile(user, updatedUser);
        }
        public User getUserByUsername(string username)
        {
            return userRepository.getUserByUsername(username);
        }
    }
}