using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Lottery
    {
        Number[] _numbers;

        /// <summary>
        /// Write six numbers from 0 to 9
        /// </summary>
        public Lottery()
        {
            _numbers = new Number[6];

            Random random = new Random();
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = new Number(random.Next(0, 9));
            }
        }

        public Number[] GetNumber()
        {
            return _numbers;
        }

        public bool WinCheck(Number[] numbers)
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (_numbers[i]!=numbers[i])
                {
                    return false;
                }
            }
            return true;
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
