using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public enum Color
    {
        blak,
        white,
        yellow,
        brown,
        red,
        blue,
        green,

    }
    public enum MotorType
    {
        automatic,
        mechanical,
    }

    public class Car
    {
        public readonly Guid id;
        public string Model { get; set; }
        public string City { get; set; }
        public int Year { get; set; }
        public Color color { get; set; }
        public MotorType motorType { get; set; }

        public Car()
        {
                
        }

        public Car(string model, int year )
        {
            id = new Guid();
            this.Model = model;
            this.Year = year;
        }
       
    }
}
