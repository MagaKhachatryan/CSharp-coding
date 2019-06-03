using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram
{

    #region Country
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
        Korean,
        France,
        Italy,
        Spain,
        Chinese,
        Argentina,
        Armenia,
        Australia,
        Austria,
        Azerbaijan,
        Belarus,
        Belgium,
        Brazil,
        Bulgaria,
        Cambodia,
        Egypt,
        Ethiopia,
        Finland,
    }
    #endregion

    #region  Color
    /// <summary>
    /// enum that includes name of colors
    /// </summary>
    public enum Colors
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
    #endregion

    #region CarModel
    /// <summary>
    /// enum representing Cars Models
    /// </summary>
    public enum CarModel
    {
        BMW,
        MercedesBenz,
        Audi,
        Volkswagen,
        
        Opel,
        Porsche,
        Fiat,
        Lancia,
        Alfa,
        Romeo,
        Lamborghini,
        Maserati,
        Ferrari,
        McLaren,
        AstonMartin,
        Vauxhall,
        Bentley,
        RollsRoyce,
        LandRover,
        Chrysler,
        Dodge,
        Jeep,
        Honda,
        Toyota, Suzuki,
        Lexus,
        Infiniti,
        Mazda,
        Mitsubishi,
        Nissan,
        Chevrolet,
        Buick,
        GMC,
        Cadillac
    }
    #endregion

    #region Filter Type
    public enum FilterType
    {
        ByModel,
        ByYear,
        ByColor,
        ByCountry,
        ByMaxSpeed,

    }
    #endregion
    /// <summary>
    /// represents a simple car ith it's mpst important facilities
    /// every car has a unique ID
    /// </summary>

    public class Car
    {
      
        #region properties
        public Guid Id { get; set; }
        public CarModel Model { get; set; }
        public long Year { get; set; }
        public Colors color { get; set; }
        public Country country { get; set; }
        public long MaxSpeed { get; set; }
       #endregion


        /// <summary>
        /// parametrless constructor
        /// </summary>
        public Car()
        {

        }


        #region paramful ctor
        /// <summary>
        /// constructor that takes three parametres
        /// car's model, produced year and country where it is produced 
        /// </summary>
        public Car (CarModel model, long year,Country country,Colors color,long maxspeed)
        {
            this.Model = model;
            this.Year = year;
            this.country = country;
            this.Id =Guid.NewGuid();
            this.color = color;
            this.MaxSpeed = maxspeed;
        }
        #endregion


        #region ToString Override

        public override string ToString()
        {
            return this.Model.ToString() + "  " +this.Id.ToString();
        }
        #endregion

        #region override Equals
        public override bool Equals(Object obj)
        {
            Car car= (Car)obj;
            return (this.Model == car.Model && this.country == car.country &&
                this.color == car.color && this.Year == car.Year && this.MaxSpeed == car.MaxSpeed);
               
        }

        #endregion
    }
}
