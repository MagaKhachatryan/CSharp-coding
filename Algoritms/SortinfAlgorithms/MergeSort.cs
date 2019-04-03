using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        static public void Merge(int[] Arr, int left, int mid, int right)
        {

            int i = 0, j = 0, k = 0;
            int count1 = mid - left + 1;
            int count2 = right - mid;

            int[] LeftArr = new int[count1], RightArr = new int[count2];


            for (i = 0; i < count1; i++)
                LeftArr[i] = Arr[left + i];
            for (j = 0; j < count2; j++)
                RightArr[j] = Arr[mid + 1 + j];

            j = 0;
            i = 0;
            k = left;
            while (i < count1 && j < count2)
            {
                if (LeftArr[i] <= RightArr[j])
                {
                    Arr[k] = LeftArr[i];
                    i++;
                }
                else
                {
                    Arr[k] = RightArr[j];
                    j++;
                }
                k++;
            }


            while (i < count1)
            {
                Arr[k] = LeftArr[i];
                i++;
                k++;
            }


            while (j < count2)
            {
                Arr[k] = RightArr[j];
                j++;
                k++;

            }
        }


        static public void mergeSort(int[] arr, int Left, int Right)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (Left < Right)
            {

                int m = Left + (Right - Left) / 2;

                mergeSort(arr, Left, m);
                mergeSort(arr, m + 1, Right);

                Merge(arr, Left, m, Right);
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
