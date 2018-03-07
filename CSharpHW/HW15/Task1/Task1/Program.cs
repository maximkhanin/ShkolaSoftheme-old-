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
            Node<int> node = new Node<int>(1);
            Node<int> node1 = new Node<int>(2);
            Node<int> node2 = new Node<int>(3);
            Node<int> node3 = new Node<int>(4);

            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Add(node1);
            doublyLinkedList.Add(node2);
            doublyLinkedList.Add(node3);
            doublyLinkedList.Add(node);
            doublyLinkedList.Add(null);
            doublyLinkedList.Remove(node1);
            doublyLinkedList.Remove(node);

            Console.WriteLine(doublyLinkedList.IsExist(node2));
            Console.WriteLine(doublyLinkedList.IsExist(node));
           
            int[] nodes = doublyLinkedList.ToArray();
            foreach (var item in nodes)
            {
                Console.WriteLine("{0} ", item);
            }

        }
    }
}
