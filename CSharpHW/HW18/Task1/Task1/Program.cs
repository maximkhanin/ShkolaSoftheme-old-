using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileOperator mobileOperator = new MobileOperator();

            MobileAccount mobileAccount1 = new MobileAccount(123);
            MobileAccount mobileAccount2 = new MobileAccount(456);
           
            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);

            mobileAccount1.MakeCall(456);
            mobileAccount2.SendMessage(456, "Hello");


        }
    }
}
