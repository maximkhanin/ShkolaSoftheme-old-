using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab2.Libs.GenerateRandomArrays randomArrays = new Lab2.Libs.GenerateRandomArrays(1000, 10000, -10, 10, 10);
           
            List<double[]> list = randomArrays.GenArrays();
            foreach (var item in list)
            {
                Console.WriteLine(Lab2.Libs.BinInsertSort.Sort(item)); 
            }
           
        }
    }
}
