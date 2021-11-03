using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HashsetPerformanceTest : PerformanceTest
    {
        public override long ExecuteTest(int elements_number)
        {
            HashSet<int> hashS = new HashSet<int>();
            this.timer.Start();

            for (int i = 0; i < 1000000; i++)
            {
                hashS.Add(this.random.Next(1234));
            }

            //int temp = hashS.FirstOrDefault(x => x == 12);
            //Console.WriteLine("Element of HashSet: " + temp);

            this.timer.Stop();

            return this.timer.ElapsedMilliseconds;
        }
    }
}
