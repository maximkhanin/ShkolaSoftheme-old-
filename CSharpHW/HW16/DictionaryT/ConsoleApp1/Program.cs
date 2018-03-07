using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "value1");
            myDictionary.Add(2, "value2");
            myDictionary.Add(3, "value3");
            myDictionary.Add(3, "value1");
            myDictionary.Remove(2, "value2");
            Console.WriteLine(myDictionary.ToString());
        }
    }
}
