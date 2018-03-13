using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MobileAccount
    {
        private int _number;
     
        public MobileAccount(int number)
        {
            _number = number;
        }

        public void MakeCall(MobileAccount mobileAccount)
        {
            Console.WriteLine("Call from {0} to {1}", mobileAccount._number, _number); 
        }

        public void SendMessage(MobileAccount mobileAccount)
        {
            Console.WriteLine("Message from {0} to {1}", mobileAccount._number, _number);
        }
    }
}
