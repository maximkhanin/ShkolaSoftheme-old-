using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Task2.PhoneBook;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Task2
{
    class MobileOperator
    {
        private readonly double _callRate = 1;
        private readonly double _messageRate = 0.5;

        private Dictionary<PhoneNumber, MobileAccount> _mobileAccounts = new Dictionary<PhoneNumber, MobileAccount>();
        public Logger Log = new Logger();

        private PhoneNumber GenPhoneNumber()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            return new PhoneNumber(Convert.ToInt64($"{rand.Next(10000, 99999)}{rand.Next(10000, 99999)}"));
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
            var Receiver = _mobileAccounts.First(i => i.Value.Number == smsEventArgs.Number);
            var Sender = (MobileAccount)sender;
            Receiver.Value.ReceiveMessage(Sender.Number, smsEventArgs.Message);
            Log.Add(new Log(Sender, Receiver.Value, _messageRate));
        }

        private void MobileAccount_CallEvent(object sender, PhoneNumber phoneNumber)
        {
            var Receiver = _mobileAccounts.First(i => i.Key == phoneNumber);
            var Sender = (MobileAccount)sender;
            Receiver.Value.ReceiveCall(Sender.Number);
            Log.Add(new Log(Sender, Receiver.Value, _callRate));
        }

        //JSON Serializer
        public void PersistJson()
        {
            var ticks = DateTime.Now.Ticks;
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (var sw = new StreamWriter(@"accounts.json"))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _mobileAccounts);
            }
            Console.WriteLine("Performance Test JSON - {0}", DateTime.Now.Ticks - ticks);
        }

        //JSON Serializer
        public void RestoreJson()
        {
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (var sw = new StreamReader(@"accounts.json"))
            using (JsonReader reader = new JsonTextReader(sw))
            {
                var collDeserialize = (Dictionary<long, MobileAccount>)serializer.Deserialize(reader,
                    typeof(Dictionary<long, MobileAccount>));
                var collAccounts = new Dictionary<PhoneNumber, MobileAccount>();
                foreach (var item in collDeserialize)
                {
                    var key = new PhoneNumber(item.Key);
                    collAccounts.Add(key, item.Value);
                }
                _mobileAccounts = collAccounts;
            }
        }
    }
}
