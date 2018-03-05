using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DoublyLinkedList<T>
    {
        Node<T> header;
        Node<T> footer;
        private int size;
        public DoublyLinkedList()
        {
            size = 0;
        }
        public void Add(T value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }

            else
            {
                if (header == null)
                {
                    header = footer = new Node<T>(value);
                }
                else
                {
                    Node<T> tmp = header;
                    header = new Node<T>(value);
                    tmp.prev = header;
                    header.next = tmp;

                }
                size += 1;
            }
        }
        public void Add(Node<T> value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (header == null)
                {
                    header = footer = value;
                }
                else
                {
                    Node<T> tmp = header;
                    header = value;
                    tmp.prev = header;
                    header.next = tmp;

                }
                size += 1;
            }
        }
        public void Print()
        {
            if (header != null)
            {
                Node<T> tmp = header;
                while (tmp != null)
                {
                    tmp.Print();
                    tmp= tmp.next;
                }
            }
        }

        public void PrintReverse()
        {
            if (footer != null)
            {
                Node<T> tmp = footer;
                while (tmp != null)
                {
                    tmp.Print();
                    tmp = tmp.prev;
                }
            }
        }
       public Node<T>[] ToNodesArray()
        {
            Node<T>[] nodes = new Node<T>[size];
            int i = 0;
            if (header != null)
            {
                Node<T> tmp = header;
                while (tmp != null)
                {
                    nodes[i] = tmp;
                    i += 1;
                    tmp = tmp.next;
                }
            }
            return nodes;
        }
        public T[] ToArray()
        {
            T[] nodes = new T[size];
            int i = 0;
            if (header != null)
            {
                Node<T> tmp = header;
                while (tmp != null)
                {
                    nodes[i] = tmp.Value;
                    i += 1;
                    tmp = tmp.next;
                }
            }
            return nodes;
        }
        public int Size()
        {
            return size;
        }

        public bool IsExist(Node<T> value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (header != null)
                {
                    Node<T> tmp = header;
                    while (tmp != null)
                    {
                        if (tmp == value)
                        {
                            return true;
                        }
                        tmp = tmp.next;
                    }
                }
                return false;
            }

        }


        public void Remove(T value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
          
            else {if (header != null)
                {
                    Node<T> tmp = header;
                    while (tmp != null)
                    {
                        if (tmp == new Node<T>(value))
                        {
                            if (tmp.prev == null)
                            {
                                header = tmp.next;
                            }
                            else
                            {
                                tmp.prev.next = tmp.next;
                            }

                            if (tmp.next == null)
                            {
                                footer = tmp.prev;
                            }

                            else
                            {
                                tmp.next.prev = tmp.prev;
                            }
                            size -= 1;
                        }
                        tmp = tmp.next;
                    }
                }
            }
        }


        public void Remove(Node<T> value)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (header != null)
                {
                    Node<T> tmp = header;
                    while (tmp != null)
                    {
                        if (tmp == value)
                        {
                            if (tmp.prev == null)
                            {
                                header = tmp.next;
                            }
                            else
                            {
                                tmp.prev.next = tmp.next;
                            }

                            if (tmp.next == null)
                            {
                                footer = tmp.prev;
                            }

                            else
                            {
                                tmp.next.prev = tmp.prev;
                            }
                            size -= 1;
                        }
                        tmp = tmp.next;
                    }
                }
            }
        }
    }
    
}

