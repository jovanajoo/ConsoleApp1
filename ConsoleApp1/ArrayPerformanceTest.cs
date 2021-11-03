using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayPerformanceTest : PerformanceTest
    {
        public override long ExecuteTest(int elements_number)
        {
            int[] arrl = new int[elements_number];
            this.timer.Start();

            for (int i = 0; i < arrl.Length; i++)
            {
                arrl[i] = this.random.Next(1234);
            }
           this.timer.Stop();

           //Console.WriteLine("Element of array: " + arrl[1]);

            return this.timer.ElapsedMilliseconds;
        }
    }
}
