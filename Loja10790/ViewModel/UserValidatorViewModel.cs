using Loja10790.Model;
using Loja10790.Model.Loja10790.Model;
using System;

namespace Loja10790.ViewModel
{
    internal class UserValidatorViewModel : ViewModelBase
    {
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged();
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool VerifyLogin()
        {
            try
            {
                UserData userData = new UserData();

                UserModel user = userData.GetUserByUsername(Username);

                if (user != null)
                {
                    bool isPasswordValid = EncryptionModel.VerifyPassword(Password, user.password);

                    if (isPasswordValid)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during login verification: " + ex.Message);
                return false;
            }
        }
    }
}
