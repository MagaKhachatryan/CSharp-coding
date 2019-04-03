using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortingAlgorithms

{
   public class InsertionSort
    {
        static public void insertionSort(int[] Arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            for (int i = 1; i < Arr.Length; i++)
            {
               int item= Arr[i];
                int j = i - 1;
                
                while (j >= 0 && Arr[j] > item)
                {
                    Arr[j + 1] = Arr[j];
                    j = j - 1;
                }
                Arr[j + 1] = item;
            }
            

            stopwatch.Stop();
            //Console.WriteLine("Time Elapsed {0}", stopwatch.Elapsed);
        }
       static  public void PrintArr(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; ++i)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
