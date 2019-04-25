using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesandStrings
{
    class Program
    {
        private static string fileName = "Test data for Exercise 3.txt";
        static void Main(string[] args)
        {
            excercise3();

            Console.ReadLine();
        }
        static public void SortAirports(List<Airport> AirportList)
        {
            for (int i = 0; i < AirportList.Count; ++i)
            {
                switch (AirportList[i].Size)
                {
                    case ("Small"):
                        {
                            AirportList[i].SizeinInt = 0;
                            break;
                        }

                    case ("Medium"):
                        {
                            AirportList[i].SizeinInt = 1;
                            break;
                        }

                    case ("Large"):
                        {
                            AirportList[i].SizeinInt = 2;
                            break;
                        }

                    case ("Mega"):
                        {
                            AirportList[i].SizeinInt = 3;
                            break;
                        }

                    case ("SuperMega"):
                        {
                            AirportList[i].SizeinInt = 4;
                            break;
                        }
                    default: break;
                }
            }
                for(int i=0;i<AirportList.Count-1;++i)
                {
                    for(int j=0;j<AirportList.Count-i-1;++j)
                    {
                    if (AirportList[j].SizeinInt > AirportList[j+1].SizeinInt)
                    {   var temp = AirportList[j];
                        AirportList[j] = AirportList[j + 1];
                        AirportList[j + 1] = temp;
                    }
                    }
                }


            }
        static public void print(List<Airport> lst)
        {
            Console.WriteLine("Airport's Name:" + "  " + "Country Code: " + "  " + "Size");
            for (int i = 0; i < lst.Count; ++i)
            {
                Console.WriteLine("{0}              {1}              {2} ", lst[i].Name, lst[i].CountryCode, lst[i].Size);
            }

        }
        static public void excercise3()
        {
            var reader = new AirportsFileReader();

            List<Airport> airports = reader.FileReadFunction(fileName);
            print(airports);
            SortAirports(airports);
            Console.WriteLine();
            print(airports);
        }
        }
    }
