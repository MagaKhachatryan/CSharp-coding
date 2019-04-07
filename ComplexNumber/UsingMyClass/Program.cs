using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexNumbers;

namespace UsingMyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber Num1 = new ComplexNumber(3,4);
            ComplexNumber Num2 = new ComplexNumber(0, 0);

            Num1 += Num2;
            Console.WriteLine(Num1.RealPart + "i" + Num1.ImPart);
        }
    }
}
