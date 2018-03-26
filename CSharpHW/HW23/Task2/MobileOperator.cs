using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
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

        public MobileOperator()
        {
            XmlTextWriter textWritter = new XmlTextWriter("contacts.xml", Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("head");
            textWritter.WriteEndElement();
            textWritter.Close();
        }

        private PhoneNumber GenPhoneNumber()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            var phoneNumber = new PhoneNumber(Convert.ToInt64($"{rand.Next(10000, 99999)}{rand.Next(10000, 99999)}"));

            XDocument doc = XDocument.Load("contacts.xml");
            var uniqCheckXElement = doc.Descendants("mobileAccount").
                    FirstOrDefault(x => x.Attribute("number").Value == phoneNumber.Number.ToString());
            
            if (uniqCheckXElement != null)
            {
                GenPhoneNumber();
            }
            return phoneNumber;
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            var phoneNumber = GenPhoneNumber();
            mobileAccount.Number = phoneNumber;

            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;

            XmlDocument document = new XmlDocument();
            document.Load("contacts.xml");

            XmlNode element = document.CreateElement("mobileAccount");
            document.DocumentElement.AppendChild(element);
            XmlAttribute attribute = document.CreateAttribute("number");
            attribute.Value = mobileAccount.Number.ToString();
            element.Attributes.Append(attribute);

            var firstNameElement = document.CreateElement("firstName");
            firstNameElement.InnerText = mobileAccount.FirstName;
            element.AppendChild(firstNameElement);

            var lastNameElement = document.CreateElement("lastName");
            lastNameElement.InnerText = mobileAccount.LastName;
            element.AppendChild(lastNameElement);

            var birthdayElement = document.CreateElement("birthday");
            birthdayElement.InnerText = mobileAccount.Birthday.ToString();
            element.AppendChild(birthdayElement);

            var emailElement = document.CreateElement("email");
            emailElement.InnerText = mobileAccount.Email;
            element.AppendChild(emailElement);

            document.Save("contacts.xml");
        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs smsEventArgs)
        {
            //Receiver.Value.ReceiveMessage(Sender.Number, smsEventArgs.Message);
            //Log.Add(new Log(Sender, Receiver.Value, _messageRate));
        }

        private void MobileAccount_CallEvent(object sender, PhoneNumber phoneNumber)
        {  
            //Log.Add(new Log(Sender, Receiver.Value, _callRate));
        }        
    }
}
