using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyDictionary<TKey, TValue>
    {
        private int counter = 0;
        private TKey[] keys = new TKey[0];
        private TValue[] values = new TValue[0];

        public int Counter()
        {
            return counter;
        }

        public void Add(TKey key, TValue value)
        {
            
                if (!(keys.Contains(key)))
                {
                    counter++;

                    Array.Resize(ref keys, counter);
                    keys[counter - 1] = key;

                    Array.Resize(ref values, counter);
                    values[counter - 1] = value;
                }  
        }


        public void Remove(TKey key, TValue value)
        {
            var flag = true;
            var tmpKeys = new TKey[keys.Length-1];
            var tmpValues = new TValue[values.Length - 1];
            int i = 0;
            var k = 0;
            while (i<keys.Length)
            {
                if (!(keys[i].Equals(key) && values[i].Equals(value)))
                {     
                    tmpKeys[k] = keys[i];
                    tmpValues[k] = values[i];
                    k += 1;
                    flag ^= false;
                }
                i += 1;
            }
            if (flag == true)
            {
                keys = tmpKeys;
                values = tmpValues;
            }
            
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (key.Equals(keys[i]))
                        index = i;
                }
                return values[index];
            }
        }

        public override string ToString()
        {
            var str = "";
            for (int i = 0; i < keys.Length; i++)
            {
                str += "Key - " + keys[i] + "; Value - " + values[i] + '\n';
            }
            return str;
        }


    }
}
