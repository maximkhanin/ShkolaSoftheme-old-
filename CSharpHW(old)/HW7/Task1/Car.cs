using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Car
    {
        private string _model;
        private string _year;
        private string _color;
        public Car(string model, string year, string color)
        {
            _model = model;
            _year = year;
            _color = color;
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
