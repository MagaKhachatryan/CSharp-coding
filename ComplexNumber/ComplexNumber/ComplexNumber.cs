using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class ComplexNumber
    {
        public double RealPart { get; private set; }
        public double ImPart { get; private set; }

        public ComplexNumber()
        {
            RealPart = 0;
            ImPart = 0;
        }

        public ComplexNumber(double realpart, double impart)
        {
            RealPart = realpart;
            ImPart = impart;
        }

        public double Modul()
         {
            return Math.Sqrt( RealPart * RealPart + ImPart + ImPart);
         }
        static public ComplexNumber operator +
            (ComplexNumber Num1, ComplexNumber Num2)
        {
            Num1.RealPart += Num2.RealPart;
            Num1.ImPart += Num2.ImPart;
            return Num1;
        }

        static public ComplexNumber operator -
            (ComplexNumber Num1, ComplexNumber Num2)
        {
            Num1.RealPart -= Num2.RealPart;
            Num1.ImPart -= Num2.ImPart;
            return Num1;
        }

        static public ComplexNumber operator*
            (ComplexNumber Num1,ComplexNumber Num2)
        {
            Num1.RealPart = Num1.RealPart * Num2.RealPart
                - Num1.ImPart - Num2.ImPart;
            Num1.ImPart = Num1.RealPart * Num2.ImPart 
                + Num1.ImPart * Num2.RealPart;
            return Num1;
        }

        static public ComplexNumber operator/(ComplexNumber Num1, ComplexNumber Num2)
        {
            if(Num2.RealPart==0 && Num2.ImPart==0)
            {
                throw new InvalidProgramException("Null is an invalid parametr");
            }

            Num1.RealPart = (Num1.RealPart * Num2.RealPart - Num1.ImPart * Num2.ImPart)
                / Num2.Modul() * Num2.Modul();
            Num1.ImPart = (Num1.RealPart * Num2.ImPart + Num1.ImPart * Num2.RealPart)
                / (Num2.Modul() * Num2.Modul());
            return Num1; 
        }
        
 
    }
    }
