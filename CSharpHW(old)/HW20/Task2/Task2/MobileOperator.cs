using System;
using System.Collections.Generic;
using System.Linq;
using Task2.PhoneBook;

namespace Task2
{
    class MobileOperator
    {
        private double callRate = 1;
        private double messageRate = 0.5;
       
        private Dictionary<PhoneNumber, MobileAccount> _mobileAccounts;
        public Logger Log { get; }

        public MobileOperator()
        {
            _mobileAccounts = new Dictionary<PhoneNumber, MobileAccount>();
            Log = new Logger();
        }

        public PhoneNumber GenPhoneNumber()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            return new PhoneNumber(Convert.ToInt64(string.Format("{0}{1}", rand.Next(10000, 99999), rand.Next(10000, 99999))));
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            var phoneNumber = GenPhoneNumber();
            while (_mobileAccounts.ContainsKey(phoneNumber))
            {
                phoneNumber = GenPhoneNumber();
            }
            mobileAccount.Number = phoneNumber;
            _mobileAccounts.Add(phoneNumber, mobileAccount);
            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;

        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs smsEventArgs)
        {
            var Receiver = _mobileAccounts.First(i => i.Value.Number == smsEventArgs.number);
            var Sender = (MobileAccount)sender;
            Receiver.Value.ReceiveMessage(Sender.Number, smsEventArgs.message);
            Log.Add(new Log(Sender, Receiver.Value, messageRate));
        }

        private void MobileAccount_CallEvent(object sender, PhoneNumber phoneNumber)
        {
            var Receiver = _mobileAccounts.First(i => i.Key == phoneNumber);
            var Sender = (MobileAccount)sender;
            Receiver.Value.ReceiveCall(Sender.Number);
            Log.Add(new Log(Sender, Receiver.Value, callRate));
        }
    }
}
