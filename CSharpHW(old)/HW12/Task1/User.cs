using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Task1
{
    class User:IUser
    {
        
        public string Name { get;  set; }
        public string Password { get;  set; }
        public MailAddress Email { get;  set; }
        public DateTime Time { get; set; }

        public User(string login, string password)
        {
            try
            {
                Email = new MailAddress(login);
                Password = password;
            }
            catch
            {
                Name = login;
                Password = password;
            }
        }
        public string GetFullInfo()
        {
            return (Name + " " + Password+ " " + Email);
        }

    }
}
