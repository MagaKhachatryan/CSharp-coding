using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit T = new Fruit();
            T[0] = 123;
            Console.WriteLine(T[0]);
        }
    }
}
