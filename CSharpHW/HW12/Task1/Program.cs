using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDataBase userDataBase = new UserDataBase();
            while (true)
            {
                Console.WriteLine("Input Login: ");
                var login = Console.ReadLine();
                if (login == "exit")
                {
                    break;
                }
                Console.WriteLine("Input Password: ");
                var password = Console.ReadLine();
                User user = new User(login, password);
         
                userDataBase.Add(user, userDataBase);
            }
            userDataBase.Dispose();


        }
    }
}
