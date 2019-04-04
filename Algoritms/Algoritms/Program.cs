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
            int size =a.Length;
            char[] b = new char[size];
            Change(a, b);

            for(int i=0;i<b.Length;++i)
            {
                switch (b[i])
                {
                    case '1':
                        Console.WriteLine("Insertion Sort ");
                        int[] B = new int[A.Length];
                        for(int k=0;k<B.Length;++k)
                        {
                            B[k] = A[k];
                        }
                        InsertionSort.insertionSort(B);
                        InsertionSort.PrintArr(B);
                        break;
                    case '2':
                        Console.WriteLine("Merge Sort");
                        int[] C = new int[A.Length];
                        for (int k = 0; k <C.Length; ++k)
                        {C[k] = A[k];
                        }
                        MergeSort.mergeSort(C, 0, C.Length - 1);
                        MergeSort.PrintArr(C);
                        break;
                    case '3':
                        Console.WriteLine("Bubble Sort");
                        int[] D = new int[A.Length];
                        for (int k = 0; k < D.Length; ++k)
                        {
                            D[k] = A[k];
                        }
                        BubbleSort.BBSort(D);
                        BubbleSort.PrintArr(D);
                        break;
                    case '4':
                        Console.WriteLine("Quick Sort");
                        int[] E= new int[A.Length];
                        for (int k = 0; k < E.Length; ++k)
                        {
                            E[k] = A[k];
                        }
                        QuickSort.quicksort(E, 0, E.Length - 1);
                        QuickSort.PrintArr(E);
                        break;
                }
                

            }
            Console.ReadKey();
            }
        static public void Change(string a,char [] b)
        {
            
            if (a.Length == 1)
                b[0] = a[0];


            if (a.Length > 1)
            {
                if (a[1] == '-')

                {
                    int m = Convert.ToInt32(a[0]);
                    int k = Convert.ToInt32(a[2]);
                    int j = 0;
                    for (int i = m; i <= k; ++i)
                    {
                        b[j] = Convert.ToChar(i);
                        ++j;
                    }

                }
                if (a.Contains(','))
                {
                    int j = 0;
                    for (int i = 0; i < a.Length; i += 2)
                    {
                        b[j] = a[i];
                        ++j;
                    }
                }
            }
        }
      
        }
 }

