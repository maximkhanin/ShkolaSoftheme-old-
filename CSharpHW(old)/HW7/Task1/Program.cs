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
            Car car = new Car("Audi","1990","blue");
            TuningAtelier.TuneCar(car);
            Console.WriteLine(car.Color.ToString());
        }
    }
}
