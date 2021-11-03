using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkedListPerformanceTest : PerformanceTest
    {
        public override long ExecuteTest(int elements_number)
        {
            LinkedList<int> linkedL = new LinkedList<int>();

            this.timer.Start();

            for (int i = 0; i < 1000000; i++)
            {
                linkedL.AddFirst(this.random.Next(1234));
            }

            //int temp = linkedL.FirstOrDefault(x => x == 10);
            //Console.WriteLine("Element of LinkedList: " + temp);

            this.timer.Stop();

            return this.timer.ElapsedMilliseconds;
        }
    }
}
