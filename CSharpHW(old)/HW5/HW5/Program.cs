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
            while (true)
            {
                try
                {
                    Console.WriteLine("Put the number from 1 to 3." + '\n' + "1 - Triangle" + '\n' + "2 - Square" + '\n' + "3 - Romb" + '\n' + "or 'ex' to exit");
                    string text = Console.ReadLine();


                    if (text == "ex")
                    {
                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine("Write the size of figure");
                        int size = int.Parse(Console.ReadLine());
                        switch (text)
                        {
                            case "1":
                                Triangle(size);
                                break;
                            case "2":
                                Square(size);
                                break;
                            case "3":
                                Romb(size);
                                break;

                        }
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }
        private static void Triangle(int k)
        {
            Console.WriteLine("Triangle - {0}", k);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < i + 1; j++)
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
