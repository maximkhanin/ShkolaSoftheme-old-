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
            Numbers numbers = new Numbers();
            Lottery lottery = new Lottery();
            var lotteryTicket = lottery.GetNumber();
            for (int i = 0; i < lotteryTicket.Length; i++)
            {
                Console.Write(lotteryTicket[i].Value);
            }
            Console.WriteLine();
            if (lottery.WinCheck(numbers.GetNumber()))
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
    }
}
