using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CarConstructor
    {
        public static Car Construct(Engine engine, Color color, Transmission transmission) {
            return new Car(engine, color, transmission);
        }
        public static Car Reconstruct(Car car,Engine engine)
        {
            car.Engine = engine;
            return car;
        }
    }
}
