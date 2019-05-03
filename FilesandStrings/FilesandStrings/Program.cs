using System;
using System.Collections.Generic;
using StudentInfo;
using System.Media;
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
          /*  Console.WriteLine("EXCERCISE 1");
            var obj = new OnlineAttendance();
            obj.InvalidNames += OnInvalidNames;
            obj.InputProcess();
            Console.WriteLine();*/

            Console.WriteLine("EXCERCISE 2");
            Console.WriteLine(excercise2("  Amerikayi Miacyal Nahangner"));
            
            Console.WriteLine("EXCERCISE 3 ");
            excercise3();
            Console.WriteLine();

            Console.WriteLine("EXCERCISE 4 ");
            excercise4();

            Console.ReadLine();
        }
        /// <summary>
        /// Handler for InvalidNames event
        /// </summary>
        /// <param name="Name"></param>
        static public void OnInvalidNames(string Name)
        {
            SystemSounds.Beep.Play();
            Console.WriteLine("Dear {0}, you are nor allowed to use this program ",Name);
        }

        /// <summary>
        /// function that sorts airports according to their size
        /// </summary>
        /// <param name="AirportList"></param>
        static public  void SortAirports(List<Airport> AirportList)
        {
            /*for (int i = 0; i < AirportList.Count; ++i)
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
            }*/
            for (int i = 0; i < AirportList.Count - 1; ++i)
            {
                for (int j = 0; j < AirportList.Count - i - 1; ++j)
                {
                    if (AirportList[j].SizeinInt > AirportList[j + 1].SizeinInt)
                    {
                        var temp = AirportList[j];
                        AirportList[j] = AirportList[j + 1];
                        AirportList[j + 1] = temp;
                    }
                }
            }

        }

        /// <summary>
        /// this function prints the givent list of airports
        /// </summary>
        /// <param name="lst"></param>
            static public void print(List<Airport> lst)
            {
                Console.WriteLine("Airport's Name:" + "  " + "Country Code: " + "  " + "Size");
                for (int i = 0; i < lst.Count; ++i)
                {
                    Console.WriteLine("{0}              {1}              {2} ", lst[i].Name, lst[i].CountryCode, lst[i].Size);
                }

            }

        /// <summary>
        /// reads the file that contains info about airports and calls sort for  the airport list
        /// </summary>
            static public void excercise3()
            {
                var reader = new AirportsFileReader();

                List<Airport> airports = reader.FileReadFunction(fileName);
                print(airports);
                SortAirports(airports);
                Console.WriteLine();
                print(airports);
            }

        /// <summary>
        /// Constructs students with their subject s and testcores 
        /// </summary>
        static public void excercise4()
        {
            StudentCatalog students = new StudentCatalog();

            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");
            Student diana = new Student(295, "Diana");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            students.AddStudent(anna);
            students.AddStudent(betty);
            students.AddStudent(carl);
            students.AddStudent(diana);
            
            foreach (var id in students.StudentsList.Keys)
            {
                foreach (var item in students.StudentsList[id].TestScores.Keys)
                {
                    Console.WriteLine(students.StudentsList[id].Name + "  " + item + "   " + students.StudentsList[id].TestScores[item]);
                }

            }
        }

       static public string excercise2(string phrase)
        {
            var acronomy = new StringBuilder();
            char[] str=phrase.ToCharArray() ;
            int j = 0;
            //check if our strings first letters are probels
            while(true)
            {
                if (str[j+1] != ' ')
                { break; }
                else
                {

                    ++j;
                }
            }
             
            for(int i=j; i < str.Length-1 ;++i)
            {
                if (i == 0 && i != ' ')
                    acronomy.Append(str[i]);
                if (i != 0)
                {
                    if (str[i] == ' ')
                    {
                        acronomy.Append(str[i + 1]);
                    }
                }
              
            }
            
           return acronomy.ToString();

        }
      
    }
}


    
