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
            var human1 = new Human(23, "Maxim");
            var human2 = new Human(23, "Maxim");
            Console.WriteLine(Human.Equals(human1, human2));
            var human3 = new Human(3, "Maxim");
            var human4 = new Human(23, "Maxim");
            Console.WriteLine(Human.Equals(human3, human4));
        }
    }
}
