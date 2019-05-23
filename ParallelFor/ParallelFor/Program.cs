using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] Arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1,9 };
               string numberOfThreads=Console.ReadLine();
               int Sum = 0;
              /* Parallel.For(0, Arr.Length, new ParallelOptions { MaxDegreeOfParallelism = Int32.Parse(numberOfThreads) },  index => 
               {

                    Sum += Arr[index];
                    ++index;
                });*/
            //  Console.WriteLine(Sum);

           
            Parallel.For(0, Arr.Length, new ParallelOptions { MaxDegreeOfParallelism = Int32.Parse(numberOfThreads) },
         // Initialize the local states
         () => 0,
         // Accumulate the thread-local computations in the loop body
         (i, loop, localState) =>
         {
             return localState + Arr[i];
         },
         // Combine all local states
         localState => Interlocked.Add(ref Sum, localState)
      );
            Console.WriteLine(Sum);


        }
    }
}
