using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class CompareByYear:IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

    public class CompareByYearModel:IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Model.CompareTo(y.Model);
        }
    }

    public class CompareByColor:IComparer<Car>
    {
        public int Compare(Car x,Car y)
        {
            return x.color.CompareTo(y.color);
        }
    }
}
