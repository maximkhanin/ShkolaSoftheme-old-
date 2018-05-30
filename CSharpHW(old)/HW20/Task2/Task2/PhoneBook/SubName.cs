using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.PhoneBook
{
    class SubName
    {
        private readonly string _name;
        public SubName(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
