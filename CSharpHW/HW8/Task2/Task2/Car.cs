using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car
    {
        public Engine Engine { get; set; }
        public Color Color { get; }
        public Transmission Transmission { get; }
        public Car(Engine engine,Color color,Transmission transmission)
        {
            Engine = engine;
            Color = color;
            Transmission = transmission;
        }
        public override string ToString()
        {
            return ("Engine - " + Engine.ToString() + ", Color - " + Color.ToString() + ", Transmission - " + Transmission.ToString() + ".");
        }

    }
}
