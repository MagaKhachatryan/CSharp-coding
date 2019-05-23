using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram
{
    /// <summary>
    /// represents a simple class that inherits from systemexception
    /// and it occurs when the car with given parametres already exists in the list of gareage's cars 
    /// </summary>
    public class CarAlreadyExists:SystemException
    {
        public CarAlreadyExists(string msg)
            :base(msg)
        {

        }
    }

    /// <summary>
    /// represents a simple class that inherits from systemexception
    /// and it occurs when the car with given parametres doesnt exist in the list of gareage's cars 
    /// </summary>
    public class CarDoesNotExist : SystemException
    {
        public CarDoesNotExist(string msg)
            : base(msg)
        {

        }
    }
}
