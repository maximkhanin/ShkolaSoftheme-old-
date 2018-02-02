using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle(4);
            Square(5);
            Romb(7);
        }
        private static void Triangle(int k)
        {
            Console.WriteLine("Triangle - {0}", k);
            for(int i = 0; i < k; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void Square(int k)
        {
            Console.WriteLine("Square - {0}", k);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void Romb(int k)
        {
            Console.WriteLine("Romb - {0}", k);
            int x = 2 * k - 1;
            int y = 1;
            while (y < 2 * k)
            {
                for (int i = x; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < y; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                y += 2;
                x -= 2;
            }
            y -= 2;
            x += 2;
            while (y != 1)
            {
                y -= 2;
                x += 2;
                for (int i = x; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < y; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                
            }
        }
    }
   
}
