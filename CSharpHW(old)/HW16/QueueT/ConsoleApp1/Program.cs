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
            MyQueue<int> myQueue = new MyQueue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);
            myQueue.Enqueue(8);
            Console.WriteLine("Queue - {0}", myQueue.ToString());
            Console.WriteLine("Operation Dequeue - {0}", myQueue.Dequeue());
            Console.WriteLine("Operation Peek - {0}", myQueue.Peek());
            Console.WriteLine("Queue - {0}", myQueue.ToString());
            Console.WriteLine("Count - {0}", myQueue.Count());
     
        }
    }
}
