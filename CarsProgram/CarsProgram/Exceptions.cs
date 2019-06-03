﻿using System;
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
    public class CarAlreadyExistsException:SystemException
    {
        public CarAlreadyExistsException(string msg)
            :base(msg)
        {

        }
    }

    /// <summary>
    /// represents a simple class that inherits from systemexception
    /// and it occurs when the car with given parametres doesnt exist in the list of gareage's cars 
    /// </summary>
    public class CarDoesNotExistException : SystemException
    {
        public CarDoesNotExistException(string msg)
            : base(msg)
        {

        }
    }

    /// <summary>
    /// represents exception class
    /// this type of exception is thrown if car's quantity is 0
    /// </summary>
    public class ThereIsNoCarException: SystemException
    {
        public ThereIsNoCarException(string msg)
            :base(msg)
        {

        }
    }
    
}