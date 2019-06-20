using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathServer
{
    public class MathService : IMathService
    {
        public double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public double Div(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }

        public double Mult(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public double Sub(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        // A method which will do appropriate operations based on the incoming request
        public double PerformOperation(string operation)
        {
            string[] arr = operation.Split(':');
            try
            {
                switch (arr[0])
                {
                    case "+":
                        {
                            return Add(Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]));
                            break;
                        }
                    case "-":
                        {
                            return Sub(Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]));
                            break;
                        }
                    case "*":
                        {
                            return Mult(Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]));
                            break;
                        }
                    case "/":
                        {
                            return Div(Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]));
                            break;
                        }
                    default:
                        Console.WriteLine("You have entered incorrect operation");
                        break;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Please enter some operation" + " " + ex.Message);
            }
            return -1;
        }
    }
}


