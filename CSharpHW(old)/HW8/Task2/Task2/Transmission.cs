using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Transmission
    {
        public string TransmissionField { get; }
        public Transmission(string transmission)
        {
            TransmissionField = transmission;
        }
        public override string ToString()
        {
            return TransmissionField;
        }
    }
}
