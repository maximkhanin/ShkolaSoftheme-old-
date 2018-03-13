using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MobileOperator
    {
        public delegate void MethodContainer(MobileAccount mobileAccount);
        public event MethodContainer Action;

        private List<MobileAccount> mobileAccounts;

        public MobileOperator()
        {
            mobileAccounts = new List<MobileAccount>();
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            mobileAccounts.Add(mobileAccount);
        }

        public void SendMessage(MobileAccount account1, MobileAccount account2)
        {
            if (mobileAccounts.Contains(account1) && mobileAccounts.Contains(account2))
            {
                Action = account1.SendMessage;
                Action.Invoke(account2);
            }
            
        }

        public void MakeCall(MobileAccount account1, MobileAccount account2)
        {
            if (mobileAccounts.Contains(account1) && mobileAccounts.Contains(account2))
            {
                Action = account1.MakeCall;
                Action.Invoke(account2);
            }
        }

       
    }
}
