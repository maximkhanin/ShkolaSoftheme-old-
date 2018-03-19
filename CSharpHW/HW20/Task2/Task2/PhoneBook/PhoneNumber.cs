using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.PhoneBook
{
    class PhoneNumber
    {
        public long Number { get; set; }
        public PhoneNumber(long number)
        {
            Number = number;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
