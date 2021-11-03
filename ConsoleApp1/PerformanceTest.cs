using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class PerformanceTest
    {
        public Random random;
        public Stopwatch timer;

        public PerformanceTest()
        {
            this.random = new Random();
            this.timer = new Stopwatch();
        }
        public abstract long ExecuteTest(int elements_number);
    }
}
