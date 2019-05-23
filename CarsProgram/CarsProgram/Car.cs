using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram
{
    /// <summary>
    /// enum that represents a number of countries where cars are mostly produced
    /// </summary>
    public enum Country
    {
        Germany,
        US,
        UK,
        Russian,
        Japan,
        Canada,
        Korea,
        France,
        Italy,
        Spain
    }

    /// <summary>
    /// enum that includes name of colors
    /// </summary>
    public enum Color
    {
        black,
        yellow,
        white,
        brown,
        violet,
        blue,
        green,
        pink,
        red
    }

    /// <summary>
    /// represents a simple car ith it's mpst important facilities
    /// every car has a unique ID
    /// </summary>
    public class Car
    {
        
        public Guid Id { get; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Color color { get; set; }
        public Country country { get; set; }
        public int MaxSpeed { get; set; }

        /// <summary>
        /// parametrless constructor
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// constructor that takes three parametres
        /// car's model, produced year and country where it is produced 
        /// </summary>
        public Car(string model,int year,Country country)
        {
            this.Model = model;
            this.Year = year;
            this.country = country;
            this.Id = new Guid();
            this.color = Color.yellow;
            this.MaxSpeed = 320;
        }
    }
}
