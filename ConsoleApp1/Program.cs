using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayPerformanceTest arrl = new ArrayPerformanceTest();
            LinkedListPerformanceTest linkedl = new LinkedListPerformanceTest();
            HashsetPerformanceTest hashs = new HashsetPerformanceTest();

            Console.WriteLine("Timer for array {0}ms", arrl.ExecuteTest(1000000));
            Console.WriteLine("Timer for LinkedList {0}ms", linkedl.ExecuteTest(1000000));
            Console.WriteLine("Timer for Hashset {0}ms", hashs.ExecuteTest(1000000));

            Console.ReadLine();
        }  
    }
}
