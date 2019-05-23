using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram
{
    /// <summary>
    /// represents a simple class that implements IComparer interface,
    /// hence giving two Cars list to be compared by the year
    /// </summary>
    public class CompareByYear : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

    /// <summary>
    /// represents a simple class that implements IComparer interface,
    /// hence giving two Cars list to be compared by the model's name
    /// </summary>
    public class CompareByModel : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Model.CompareTo(y.Model);
        }
    }
}
