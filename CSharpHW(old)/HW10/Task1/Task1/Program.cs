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
            int[] array = { 1, 2, 1, 3, 4, 3, 4 };
            Console.WriteLine(Uniq(array));
            
        }

        public static int Uniq(params int[] arr)
        {
            var tmp = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                tmp ^= arr[i];
            }
            return tmp;
        }
    }
}
