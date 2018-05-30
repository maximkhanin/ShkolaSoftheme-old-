using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    class Authenticator : IAuthenticator
    {


        public bool AuthenticateUser(IUser user, UserDataBase userDataBase)
        {
            if (string.IsNullOrEmpty(user.Name))
            {
                return (LoginCheck(user.Email, user.Password, userDataBase));
            }
            else
            {
                return (LoginCheck(user.Name, user.Password, userDataBase));
            }

        }

        private bool LoginCheck(string name, string password, UserDataBase userDataBase)
        {

            foreach (var item in userDataBase.UsersList)
            {
                if (item.Name == name)
                {
                    if (item.Password == password)
                    {
                        Console.WriteLine(item.Time);
                        item.Time = DateTime.Now;
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Password is incorrect");
                        return false;
                    }

                }
            }

            return true;
        }
        private bool LoginCheck(MailAddress email, string password, UserDataBase userDataBase)
        {
            foreach (var item in userDataBase.UsersList)
            {
                if (item.Email.Address == email.Address)
                {
                    if (item.Password == password)
                    {
                        Console.WriteLine(item.Time);
                        item.Time = DateTime.Now;
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Password is incorrect");
                        return false;
                    }

                }
            }
            return true;
        }

    }
}
