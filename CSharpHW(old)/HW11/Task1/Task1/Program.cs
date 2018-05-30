using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Test1");
            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print("Test2");
            photoPrinter.Print("Test2","img2");
            ColourPrinter colourPrinter= new ColourPrinter();
            colourPrinter.Print("test3");
            colourPrinter.Print("test3",ConsoleColor.Cyan);
        }
    }
}