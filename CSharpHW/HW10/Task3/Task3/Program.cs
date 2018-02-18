using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            MyArray myArr = new MyArray(arr);
            int [] arr1 = myArr.Add(8);
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0} ",arr1[i]);
            }
            Console.WriteLine();
            Console.WriteLine(new MyArray(arr1).Contains(8));
            Console.WriteLine(new MyArray(arr1).GetByIndex(1));
        }
    }
}
