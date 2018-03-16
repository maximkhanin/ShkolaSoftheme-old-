using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    
  

    class MobileOperator
    {
        private double callRate = 1;
        private double messageRate = 0.5;
        
        private List<MobileAccount> _mobileAccounts;
        private List<Log> _Log;

        public MobileOperator()
        {
            _mobileAccounts = new List<MobileAccount>();
            _Log = new List<Log>();
           
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            _mobileAccounts.Add(mobileAccount);
            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;

        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs e)
        {
            var tmp = _mobileAccounts.First(i => i.Number == e.number);
            var tmp2 = (MobileAccount)sender;
            tmp.ReceiveMessage(tmp2.Number, e.message);
            _Log.Add(new Log(tmp2, tmp, messageRate));
        }

        private void MobileAccount_CallEvent(object sender, int e)
        {
            var tmp = _mobileAccounts.First(i => i.Number == e);
            var tmp2 = (MobileAccount)sender;
            tmp.ReceiveCall(tmp2.Number);
            _Log.Add(new Log(tmp2, tmp, callRate));
        }

        public void MostFrequentlyReceivingNumbers(int count)
        {
            var Result = _Log.GroupBy(x => x.Receiver).Take(count);
            foreach (var item in Result)
            { 
                var tmp = 0.0;
                foreach (var t in item)
                    tmp += t.Rate;
                Console.WriteLine("{0} - {1}", item.Key.Number,tmp); 
            }
        }

        public void MostFrequentlySendingNumbers(int count)
        {
            var Result = _Log.GroupBy(x => x.Sender).Take(count);
            foreach (var item in Result)
            {
                var tmp = 0.0;
                foreach (var t in item)
                    tmp += t.Rate;
                Console.WriteLine("{0} - {1}", item.Key.Number, tmp);

            }
        }
    }
}
