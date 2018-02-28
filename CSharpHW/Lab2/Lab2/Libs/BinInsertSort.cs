using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Libs
{
    public class BinInsertSort
    {
        public static long Sort(double[] a)
        {
            var ticks = DateTime.Now.Ticks;
            double x;
            int  left, right, sred;
            int n = a.Length;
            for(int i=1; i < n; i++)
            {
                if (a[i - 1] > a[i])
                {
                    x = a[i];
                    left = 0;
                    right = i - 1;
                    do
                    {
                        sred = (left + right) / 2;
                        if (a[sred] < x)
                        {
                            left = sred + 1;
                        }
                        else
                        {
                            right = sred - 1;
                        }
                    } while (left <= right);
                    for(int j = i - 1; j >= left; j--)
                    {
                        a[j + 1] = a[j];
                        
                    }
                    a[left] = x;
                }
            }
            return (DateTime.Now.Ticks - ticks);
        }
    }
}
