using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the left operand");
            double leftOperand = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation");
            var operation = Console.ReadLine();
            Console.WriteLine("Enter the right operand");
            double rightOperand = double.Parse(Console.ReadLine());
            Console.WriteLine("Result");
            calculate(leftOperand, rightOperand, operation);
            Console.ReadKey();
        }
        private static void calculate(double leftOperand, double rightOperand, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(Math.Round(leftOperand + rightOperand, 2));
                    break;
                case "-":
                    Console.WriteLine(leftOperand - rightOperand);
                    break;
                case "*":
                    Console.WriteLine(leftOperand * rightOperand);
                    break;
                case "/":
                    Console.WriteLine(leftOperand / rightOperand);
                    break;
            }
        }
    }
}
