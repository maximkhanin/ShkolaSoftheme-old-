using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyArray
    {
        private int[] _array;
        public MyArray(int[] arr)
        {
            _array = arr;
        }
        public int[] Add(int element)
        {
            int[] arr = new int[_array.Length+1];
            Array.Copy(_array, arr, _array.Length);
           
            arr[_array.Length] = element;
            return arr;
        }
        public bool Contains(int element)
        {
            for(int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == element)
                {
                    return true;
                }
                
            }
            return false;
        }
        public int GetByIndex(int index)
        {
            return _array[index];
        }
        
    }
}
