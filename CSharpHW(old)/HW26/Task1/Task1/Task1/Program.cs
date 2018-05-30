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
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.WriteLine("Input the path to the directory");
            var path = Console.ReadLine();
            var replaceText = new ReplaceText("old", "new");
            replaceText.ReplaceTextInFiles(path);
            Console.WriteLine("Program is finished");
        }
    }
}
