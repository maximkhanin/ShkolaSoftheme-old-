using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> next;
        public Node<T> prev;
        public Node(T value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                Value = value;
            }
            
        }
        public void Print()
        {
            Console.WriteLine(Value + " ");
        }
    }
}
