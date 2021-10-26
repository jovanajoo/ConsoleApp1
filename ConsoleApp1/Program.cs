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
            const int numberOfElements = 1000000;
            Stopwatch linkedTimer = new Stopwatch();

            int[] arrl = new int[numberOfElements];

            LinkedList<int> linkedL = new LinkedList<int>();

            HashSet<int> hashS = new HashSet<int>();

            MeasureArrayPerformance(arrl);
            MeasureLinkedListPerformance(linkedL);
            MeasureHashSetPerformance(hashS);

            Console.ReadLine();
        }
        static void MeasureArrayPerformance(int[] arrl)
        {
            var random = new Random();
            Stopwatch arrayTimer = new Stopwatch();
            arrayTimer.Start();

            for (int i = 0; i < arrl.Length ; i++)
            {
                arrl[i] = random.Next(1234);
            }
            Console.WriteLine("Element of array: " + arrl[1]);
            arrayTimer.Stop();

            Console.WriteLine("Time for array: {0}ms", arrayTimer.ElapsedMilliseconds);
        }

        static void MeasureLinkedListPerformance(LinkedList<int> linkedL)
        {
            var random = new Random();
            Stopwatch linkedTimer = new Stopwatch();
            linkedTimer.Start();
      
            for(int i = 0; i < 1000000; i++)
            {
                linkedL.AddFirst(random.Next(1234));
            }

            int temp = linkedL.FirstOrDefault(x => x == 10 ); 
            Console.WriteLine("Element of LinkedList: " +temp);

            linkedTimer.Stop();

            Console.WriteLine("Time for LinkedList: {0}ms", +linkedTimer.ElapsedMilliseconds);
        }

        static void MeasureHashSetPerformance(HashSet<int> hashS)
        {
            var random = new Random();
            Stopwatch hashTimer = new Stopwatch();
            hashTimer.Start();

            for (int i = 0; i < 1000000; i++)
            {
                hashS.Add(random.Next(1234));
            }

            int temp = hashS.FirstOrDefault(x => x == 12);
            Console.WriteLine("Element of HashSet: " + temp);

            hashTimer.Stop();

            Console.WriteLine("Time for HashSet: {0}ms", +hashTimer.ElapsedMilliseconds);


        }
    }
}
