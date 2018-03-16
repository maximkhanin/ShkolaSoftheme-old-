using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator mobileOperator = new MobileOperator();

            MobileAccount mobileAccount1 = new MobileAccount(123,"Alex");
            MobileAccount mobileAccount2 = new MobileAccount(456,"Max");

            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);
            mobileAccount1.AddContact(456, "Max");

            mobileAccount2.MakeCall(123);
            mobileAccount2.MakeCall(123);
            mobileAccount2.MakeCall(123);
            mobileAccount2.MakeCall(123);
            mobileAccount1.MakeCall(456);
            mobileAccount1.MakeCall(456);
            mobileAccount1.MakeCall(456);

            mobileAccount2.SendMessage(123, "Hello");


            Console.WriteLine("Most Frequently Receiving Numbers");
            mobileOperator.MostFrequentlyReceivingNumbers(2);

            Console.WriteLine("Most Frequently Sendering Numbers");
            mobileOperator.MostFrequentlySendingNumbers(5);
        }
    }
}
