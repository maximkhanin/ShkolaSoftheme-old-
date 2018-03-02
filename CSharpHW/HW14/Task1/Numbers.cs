using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Numbers
    {
        Number[] _numbers;

        /// <summary>
        /// Write six numbers from 0 to 9
        /// </summary>
        public Numbers()
        {
            _numbers = new Number[6];
            Console.WriteLine("Input six numbers");
            for (int i = 0; i < _numbers.Length; i++)
            {
                
                _numbers[i] = Validate(Console.ReadLine());
            }
        }

        public Number[] GetNumber()
        {
            return _numbers;
        }

        public Number Validate(string value)
        {

            Regex regex = new Regex("[^0-9]+");
           
            if (value.Length==1 && !regex.IsMatch(value))
            {
                return new Number(int.Parse(value));
            }
            else
            {
                throw new FormatException();
            }

        }

        public int Length
        {
            get { return _numbers.Length; }
        }

        public Number this[int index]
        {
            get
            {
                return _numbers[index];
            }
            set
            {
                _numbers[index] = value;
            }
        }


    }
}
