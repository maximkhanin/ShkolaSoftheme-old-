using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            TuningAtelier.TuneCar(car);
            Console.WriteLine(car.Color.ToString());
        }
    }
}
