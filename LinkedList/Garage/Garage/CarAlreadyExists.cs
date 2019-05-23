using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class CarAlreadyExists:System.Exception
    {
        public CarAlreadyExists(string msg)
            :base(msg)
        {

        }
    }

    public class CarDoesNotExsist : System.Exception
    {
        public CarDoesNotExsist(string msg)
            : base(msg)
        {
            
        }
    }
}
