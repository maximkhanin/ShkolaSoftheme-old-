using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var color = Color.Black;
            var engine = Engine.AJ30;
            var transmission = Transmission.AS66RC;
            var car = CarConstructor.Construct(engine, color, transmission);
            Console.WriteLine(car.ToString());
            car = CarConstructor.Reconstruct(car, Engine.E32);
            Console.WriteLine(car.ToString());
            
        }
    }
}
