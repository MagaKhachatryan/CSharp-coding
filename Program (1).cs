using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Train t1 = new Train(Place.Andranik, new DateTime(2000, 5, 29));
            Train t2 = new Train(Place.Barekamutyun, new DateTime(2000, 6, 28));
            Train t3 = new Train(Place.Davo, new DateTime(2000, 1, 23));
            
            Station Yerevan = new Station();

            Yerevan.AddTrain(t1);
            Yerevan.AddTrain(t2);
            Yerevan.AddTrain(t3);

            foreach (Train t in Yerevan) { Console.WriteLine(t.Place ); }
            Console.WriteLine("\n\n");
            Yerevan.SortByArrivalTime();
            foreach (Train t in Yerevan) { Console.WriteLine(t.Place); }
        }
    }
}
