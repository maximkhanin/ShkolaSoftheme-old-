using System;
using Task2.PhoneBook;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileOperator = new MobileOperator();
      
            var mobileAccount1 = new MobileAccount("Max", "Kh", new DateTime(1998, 6, 23), "test@mail.com");
            var mobileAccount2 = new MobileAccount("Alex", "Kh", new DateTime(1992, 11, 27), "test1@mail.com");

            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);
            mobileOperator.AddNumber(mobileAccount1);

            
        }
    }
}
