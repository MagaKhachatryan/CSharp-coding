using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesandStrings
{
    /// <summary>
    /// Class represents an airport
    /// </summary>
    public class Airport
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Size { get; set; }
        public AirportSizes SizeinInt { get; set; }

        
    }
        
    public enum AirportSizes
    {
        Small=0,
        Medium=1,
        Large=2,
        Mega=3,
        SuperMega=4,
    }
}
