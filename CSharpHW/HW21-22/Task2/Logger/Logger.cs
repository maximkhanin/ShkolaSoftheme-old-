using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Logger: List<Log>
    {
        public void MostFrequentlyReceivingNumbers(int count)
        {
            var Result = this.GroupBy(x => x.Receiver);
            foreach (var item in Result)
            {
                var rate = 0.0;
                foreach (var t in item)
                    rate += t.Rate;
                Console.WriteLine("{0} - {1}", item.Key.Number, rate);
            }
        }

        public void MostFrequentlySendingNumbers(int count)
        {
            var Result = this.GroupBy(x => x.Sender);
            foreach (var item in Result)
            {
                var rate = 0.0;
                foreach (var t in item)
                    rate += t.Rate;
                Console.WriteLine("{0} - {1}", item.Key.Number, rate);
            }
        }
    }
}
