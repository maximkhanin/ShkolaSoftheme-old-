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
            var color = new Color("red");
            var engine = new Engine("V6");
            var transmission = new Transmission("Manual transmission");
            var car = CarConstructor.Construct(engine, color, transmission);
            Console.WriteLine(car.ToString());
            car = CarConstructor.Reconstruct(car, new Engine("V8"));
            Console.WriteLine(car.ToString());
            
        }
    }
}
