using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] Arr = { 1, 1, 1, 1, 1, 1, 1, 1, 1,9 };
            Random rnd = new Random();
            ParallelOptions opt = new ParallelOptions();
            opt.MaxDegreeOfParallelism = rnd.Next(2, Arr.Length);
            int Sum = 0;
            
            Parallel.For(0, Arr.Length, opt, index =>
             {

                 Sum += Arr[index];
                 ++index;
             });
            Console.WriteLine(Sum);
            
        }
    }
}
