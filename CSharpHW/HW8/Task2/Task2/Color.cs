using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Color
    {
        public string ColorField { get; }
        public Color(string color)
        {
            ColorField = color;
        }
        public override string ToString()
        {
            return ColorField;
        }
    }
}
