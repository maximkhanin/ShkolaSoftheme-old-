using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyQueue<T>
    {
        private T[] _array;
        private int size;
        private const int defaultCapacity = 10; //The default size of array
        private int capacity; //The size of array
        private int head; //The index of the first elem of the array
        public MyQueue()
        {
            capacity = defaultCapacity;
            _array = new T[defaultCapacity];
            size = 0;
            head = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
        //
        // Summary:
        //     Adds an object to the end of the System.Collections.Generic.Queue`1.
        //
        public void Enqueue(T newElement)
        {
            if (size == capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(_array, 0, newQueue, 0, _array.Length);
                _array = newQueue;
                capacity *= 2;
            }
            size++;
            _array[size-1] = newElement;
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            var tmp = _array[head];
            T[] newQueue = new T[capacity];
            Array.Copy(_array, 1, newQueue, 0, _array.Length-1);
            _array = newQueue;
            size--;
            return tmp;
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return _array[head];
        }

        public int Count()
        {
                return size;
        }

        public override string ToString()
        {
            var str = "";
            for (int i = 0; i < size; i++)
            {
                str += _array[i] + " ";
            }
            return str;
        }
    }
}

