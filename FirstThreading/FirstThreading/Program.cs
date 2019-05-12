using System;
using System.Threading;
using System.Threading.Tasks;

namespace FirstThreading
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sum1 = 0, sum2 = 0;
            int[] arr = { 8, 4, 5, 9, 1 };
            Thread FirstHalf = new Thread(()=>sum1=F1(ref arr));
            Thread SecondHalf = new Thread(() => sum2 = F2(ref arr));
            FirstHalf.Start();
            SecondHalf.Start();
            FirstHalf.Join();
            SecondHalf.Join();

            Console.WriteLine(sum1+sum2);
            



        }
        static public int F1(ref int[] Arr)
        {
            int Sum1 = 0;
            for(int i = 0;i<Arr.Length/2;++i)
            {
                Sum1 += Arr[i];
            }
            Console.WriteLine("First Half sum+{0}" ,Sum1);
            return Sum1;
        }
        static public int F2(ref int[] Arr)
        {
            
            int Sum2 = 0;
            for (int i = Arr.Length / 2; i < Arr.Length ; ++i)
            {
                Sum2 += Arr[i];
            }
            Console.WriteLine("Second Half sum+{0}",Sum2);
            return Sum2;
        }
        /*private static void SayHello(object a)
        {
           // int x = (int)a;
            // Thread.Sleep((rnd.Next(200, 300)));
            Console.WriteLine(a + " Hello World " + Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground = false);

        }*/
    }
}