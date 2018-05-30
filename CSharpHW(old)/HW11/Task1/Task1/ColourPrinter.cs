using System;

namespace Task1
{
    public class ColourPrinter: Printer
    {
        public override void Print(string pr)
        {
            Console.WriteLine("Colour Printer - {0}", pr);
        }

        public void Print(string pr, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Colour Printer - {0}", pr);
        }
    }
}