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
            MobileAccount mobileAccount1 = new MobileAccount(1234, "Max");
            MobileAccount mobileAccount2 = new MobileAccount(5678, "Alex");
            mobileAccount1.AddContact(mobileAccount2);
            MobileOperator mobileOperator = new MobileOperator();
            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);
            mobileOperator.MakeCall(mobileAccount1, mobileAccount2);
        }
    }
}
