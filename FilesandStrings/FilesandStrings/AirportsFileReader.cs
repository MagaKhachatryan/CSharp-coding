using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesandStrings
{
    /// <summary>
    /// The class for reading file that contains 
    /// info about airports
    /// </summary>
    class AirportsFileReader
    {
        //fileName that must be readed
        private string fileName;
 
        //parametrless constructor
        public AirportsFileReader()
        {

        }

        //parametrful constructor
        public AirportsFileReader(string fileName)
        {
            this.fileName = fileName;
        }

        //Function that reads the file which name is passed as parametr
        public List<Airport> FileReadFunction(string fileName)
        {
            int lineCount = 0;
            // List which will contain all the airports 
            List<Airport> Airports = new List<Airport>();
            //constructing the instance of streamreader
            using (StreamReader reader = new StreamReader(fileName))
            {
                //
                string headerLine = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(' ');
                    var airport = new Airport()
                    {
                        Name = columns[0],
                        CountryCode = columns[1],
                        Size = columns[2],
                    };
                    Airports.Add(airport);
                    lineCount++;
                }
            }
            return Airports;
        }

    }
}
