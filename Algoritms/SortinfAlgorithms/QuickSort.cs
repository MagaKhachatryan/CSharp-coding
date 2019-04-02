using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        static public int ArraysSeperation(int[] Arr, int left, int right)
        {
            int pivot = Arr[left];
            while (true)
            {
                while (Arr[left] < pivot)
                    left++;

                while (Arr[right] > pivot)
                    right--;


                if (left < right)
                {
                    int temp = Arr[left];
                    Arr[left] = Arr[right];
                    Arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quicksort(int[] arr, int Left, int Right)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (Left < Right)
            {
                int pivot = ArraysSeperation(arr, Left, Right);
                if (pivot > 1)
                {
                    quicksort(arr, Left, pivot - 1);
                }
                if (pivot + 1 < Right)
                {
                    quicksort(arr, pivot + 1, Right);
                }
            }
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(arr[i]);
            }

            stopwatch.Stop();
            Console.WriteLine("Time Elapsed {0}", stopwatch.Elapsed);
        }
    }
}
