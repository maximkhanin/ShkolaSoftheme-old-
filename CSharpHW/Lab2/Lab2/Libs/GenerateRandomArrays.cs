using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Libs
{
    public class GenerateRandomArrays
    {
        public int MinSize { get; set; }
        public int MaxSize { get; set; }
        public int MaxRange { get; set; }
        public int MinRange { get; set; }
        public int Count { get; set; }
        public GenerateRandomArrays(int minSize, int maxSize, int minRange, int maxRange, int count)
        {
            MinSize = minSize;
            MaxSize = maxSize;
            MaxRange = maxRange * 10;
            MinRange = minRange * 10;
            Count = count;
        }
        public List<double[]> GenArrays()
        {
            Random random = new Random();
            List<double[]> list = new List<double[]>();
            for (int i = 0; i < Count; i++)
            {
                int size = random.Next(MinSize, MaxSize);
                double[] array = new double[size];
                for (int j = 0; j < size; j++)
                {
                    array[j] = Convert.ToDouble(random.Next(MinRange,MaxRange)/10.0);
                }
                list.Add(array);
            }
            return (list);
        }
    }
}
