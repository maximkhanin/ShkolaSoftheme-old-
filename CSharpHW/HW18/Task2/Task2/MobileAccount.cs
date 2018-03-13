using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MobileAccount
    {
        private int _number;
        private string _name;
        private List<MobileAccount> _contacts;
        public MobileAccount(int number, string name)
        {
            _number = number;
            _name = name;
            _contacts = new List<MobileAccount>();
        }

        public void MakeCall(MobileAccount mobileAccount)
        {
            if (_contacts.Contains(mobileAccount))
            {
                Console.WriteLine("Call from {0} to {1}", mobileAccount._name, _number );
            }
            else
            {
                Console.WriteLine("Call from {0} to {1}", mobileAccount._number, _number );
            }
        }

        public void AddContact(MobileAccount mobileAccount)
        {
            _contacts.Add(mobileAccount);
        }

        public void SendMessage(MobileAccount mobileAccount)
        {
            if (_contacts.Contains(mobileAccount))
            {
                Console.WriteLine("Message from {0} to {1}", mobileAccount._name, _number);
            }
            else
            {
                Console.WriteLine("Message from {0} to {1}", mobileAccount._number, _number);
            }
            
        }
    }
}
