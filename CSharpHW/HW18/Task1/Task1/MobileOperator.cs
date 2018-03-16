using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MobileOperator
    {
        private List<MobileAccount> mobileAccounts;

        public MobileOperator()
        {
            mobileAccounts = new List<MobileAccount>();
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            mobileAccounts.Add(mobileAccount);
            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;
            
        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs e)
        {
            var tmp = mobileAccounts.First(i => i.Number == e.number);
            var tmp2 = (MobileAccount)sender;
            tmp.ReceiveMessage(tmp2.Number, e.message);

        }

        private void MobileAccount_CallEvent(object sender, int e)
        {
            var tmp = mobileAccounts.First(i => i.Number == e);
            var tmp2 = (MobileAccount)sender;
            tmp.ReceiveCall(tmp2.Number);
        }
    }
}
