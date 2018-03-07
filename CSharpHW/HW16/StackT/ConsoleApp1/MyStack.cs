using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyStack<T>
    {
        private T[] _array; 
        private const int defaultCapacity = 10; 
        private int size; 

        public MyStack()
        {
            size = 0;
            _array = new T[defaultCapacity];
        }

        public bool IsEmpty() 
        {
            return size == 0;
        }

        public int Count  
        {
            get
            {
                return size;
            }
        }
       
        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            var tmp = _array[size-1];
            T[] newArray = new T[_array.Length];
            Array.Copy(_array, 0, newArray, 0, size-1);
            _array = newArray;
            size -= 1;
            return tmp;
        }

        public void Push(T newElement)
        {
            if (size == _array.Length) 
            { 
                T[] newArray = new T[2 * _array.Length];
                Array.Copy(_array, 0, newArray, 0, size);
                _array = newArray;
            }
            _array[size++] = newElement; 
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return _array[size - 1];
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
