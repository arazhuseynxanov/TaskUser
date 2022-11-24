using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    internal class User
    {
        private string _userName;
        private string _password;
        private bool _isSignedIn;
        public string Username
        {
            get { return _userName; }
            set
            {
                value = value.Trim();
                if (value.Length >= 6 && value.Length <= 25 && CheckPassword(value))
                {
                    _userName = value;
                }
            }
        } 
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 8 && value.Length <= 25)
                {
                    _userName = value;
                }
            }
        }
        public bool IsSignedIn
        {
            get { return _isSignedIn; }
            set { _isSignedIn = value; }
        }

        public User(string userName, string password,bool isSignedIn)
        {
            Username = userName;
            Password = password;
            IsSignedIn = isSignedIn;
            
        }
        public bool CheckPassword(string password)
        {
            bool result;
            for (int i = 0; i < password.Length; i++)
            {
                result = char.IsDigit(password[i]);
                if (result == true)
                {
                    return true;
                }
            }
            return false;

            for (int i = 0; i < password.Length; i++)
            {
                result = char.IsUpper(password[i]);
                if (result == true)
                {
                    return true;
                }
            }
            return false;

            for (int i = 0; i < password.Length; i++)
            {
                result = char.IsLower(password[i]);
                if (result == true)
                {
                    return true;
                }
            }
            return false;
        }
        public void Login(string ad,string sifre)
        {
            
        }



    }

}
