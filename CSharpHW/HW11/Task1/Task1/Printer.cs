using System;

namespace Task1
{
    public class Printer
    {
        public virtual void Print(string pr)
        {
            Console.WriteLine("Printer - {0}",pr);
        }
    }
}