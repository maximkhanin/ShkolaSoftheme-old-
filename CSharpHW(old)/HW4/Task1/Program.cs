using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryZodiacSigns;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();
        }
        private static void Run()
        {
            ZodiacSigns zodiacSigns = new ZodiacSigns();
            Console.WriteLine("Enter the date of birth in the format: DD / MM / YYYY");
            string[] dateOfBirth = (Console.ReadLine()).Split('/');
            Console.WriteLine(zodiacSigns.Run((int.Parse(dateOfBirth[0])), (int.Parse(dateOfBirth[1])), (int.Parse(dateOfBirth[2]))));
        }
    }

}
