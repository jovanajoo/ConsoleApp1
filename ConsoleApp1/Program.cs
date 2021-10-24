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
            const int numberOfElement = 1000000;

            Stopwatch linkedTimer = new Stopwatch();
            int[] arrl = new int[numberOfElement];

           

            measureArrayPerformance(arrl);
            Console.ReadLine();

        }

        static void measureArrayPerformance(int[] arrl)
        {
            var random = new Random();
            Stopwatch arrayTimer = new Stopwatch();
            arrayTimer.Start();

            for (int i = 0; i < arrl.Length ; i++)
            {
                arrl[i] = random.Next(1000000);
            }
            Console.WriteLine("ELement niza: " + arrl[1]);
            arrayTimer.Stop();
            Console.WriteLine("Za dodavanje lemenata array niza i trazenje odredjenog elementa potrebno je {0}ms", arrayTimer.ElapsedMilliseconds);
        }
    }
}
