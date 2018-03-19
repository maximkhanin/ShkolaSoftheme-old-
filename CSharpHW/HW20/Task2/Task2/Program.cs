using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Task2.PhoneBook;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator mobileOperator = new MobileOperator();
      
            MobileAccount mobileAccount1 = new MobileAccount("Max", "Kh", new DateTime(1998, 6, 23), new MailAddress("test@mail.com"));
            Validate(mobileAccount1);

            MobileAccount mobileAccount2 = new MobileAccount("Alex", "Kh", new DateTime(1992, 11, 27), new MailAddress("test1@mail.com"));
            Validate(mobileAccount2);

            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);

            mobileAccount1.AddContact(mobileAccount2.Number, new SubName("Alex"));

            mobileAccount1.MakeCall(mobileAccount2.Number);
            mobileAccount1.MakeCall(mobileAccount2.Number);
            mobileAccount1.MakeCall(mobileAccount2.Number);

            mobileAccount2.SendMessage(mobileAccount1.Number, "Hello");

            Console.WriteLine("Most Frequently Receiving Numbers");
            mobileOperator.Log.MostFrequentlyReceivingNumbers(5);

            Console.WriteLine("Most Frequently Sendering Numbers");
            mobileOperator.Log.MostFrequentlySendingNumbers(5);
        }

        private static void Validate(MobileAccount mobileAccount)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(mobileAccount);
            if (!Validator.TryValidateObject(mobileAccount, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("User '{0} {1}' is Valid", mobileAccount.FirstName, mobileAccount.LastName);
            }
        }
    }
}
