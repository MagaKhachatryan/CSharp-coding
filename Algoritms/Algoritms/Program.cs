using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SortingAlgorithms;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; ++i)
            {
                A[i] = random.Next(0, 100);
                Console.WriteLine(A[i] + " ");
            }

          
            string a=Console.ReadLine();
            char[] b = new char[4];
            if(a.Contains('-'))
            {
                int m = Convert.ToInt32(a[0]);
                int k = Convert.ToInt32(a[3]);
                for(int i=0; i<k; ++i)
                {
                    b[i] =Convert.ToChar(m);
                    ++m;
                }    
            }
            if(a.Contains(','))
            {
                int j = 0;
                for(int i=0;i<a.Length; i+=2)
                {
                    b[j] = a[i];
                }
            }

            for(int i=0;i<b.Length;++i)
            {
                switch (b[i])
                {
                    case '1':
                        Console.WriteLine("Insertion Sort ");
                        InsertionSort.insertionSort(A);
                        break;
                    case '2':
                        Console.WriteLine("Merge Sort");
                        MergeSort.mergeSort(A, 0, A.Length - 1);
                        break;
                    case '3':
                        Console.WriteLine("Bubble Sort");
                        BubbleSort.BBSort(A);
                        break;
                    case '4':
                        Console.WriteLine("Quick Sort");
                        QuickSort.quicksort(A, 0, A.Length - 1);
                        break;
                      
                }

            }
           
          

                
            }
            
                  
           
        }
 }

