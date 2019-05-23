using Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Car x = new Car("BMV",2000);
            Car y = new Car("Mercedes", 1999);
            Console.WriteLine(x.color);
        }
    }
}
