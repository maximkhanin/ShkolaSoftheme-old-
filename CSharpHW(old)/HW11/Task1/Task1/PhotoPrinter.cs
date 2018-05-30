using System;

namespace Task1
{
    public class PhotoPrinter: Printer
    {
        public override void Print(string pr)
        {
            Console.WriteLine("Photo Printer - {0}", pr);
        }

        public void Print(string pr, string photo)
        {
            Console.WriteLine("Photo Printer - {0}, Photo - {1}", pr, photo);
        }
    }
}