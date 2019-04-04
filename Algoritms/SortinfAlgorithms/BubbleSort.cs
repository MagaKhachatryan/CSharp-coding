using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
     
    
       static public void BBSort(int [] Arr)
        {
           
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
           
            for (int i = 0; i < Arr.Count()-1; ++i)
            {
                for(int j=0;j<Arr.Count()-i-1;++j)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int item = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = item;
                    }
                }

            }
            
            stopwatch.Stop();
        }

        static public void PrintArr(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; ++i)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
    
}
