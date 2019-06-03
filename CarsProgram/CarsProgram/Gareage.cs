using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram
{
    
   
    /// <summary>
    /// the class represents gareage where all cars are stored ..
    /// Cars can be registered in the list of gareage's machines and can be removed out of the list
    /// class is enumerable
    /// </summary>
     public class Gareage:IEnumerable<Car>  
    {
        static private Dictionary<Guid,KeyValuePair<Car,int>> Cars =new Dictionary<Guid, KeyValuePair<Car,int>>();
        
        /// <summary>
        ///help function that organizes the process of getting cars 
        /// </summary>
        static  public List<Car> GetCarsinGareage
        {
            get
            {
                var tempCar = new List<Car>();
                foreach (var key in Cars.Keys)
                {
                    
                        tempCar.Add(Cars[key].Key);
                    
                }
                return tempCar;
            }
        }

        #region AddCar
        /// <summary>
        /// function that adds car in the dictionary
        /// </summary>
        /// <param name="item"></param>
       static  public void AddCar(Car car)
        {
            if (car != null)
            {
             foreach (var item in Cars.Keys)
            {
                if(Cars[item].Key.Equals(car))
                {
                    car.Id = item;
                    int x = Cars[item].Value;
                    Cars[item] = new KeyValuePair<Car, int>(car, ++x);
                    return;
                }
            }
            Cars.Add(car.Id, new KeyValuePair<Car, int>(car, 1));
                
            }
        }
        #endregion

      
        
        #region Remove Car
        /// <summary>
        /// function that removes car from the dictionary
        /// </summary>
        /// <returns></returns>
       static public void RemoveCar(Car item)
        {
            if(!Cars.Keys.Contains(item.Id))
            {
                throw new CarDoesNotExistException("This Car  isn't in the list of gareage's machines");
            }
            if(Cars[item.Id].Value==0)
            {
                throw new ThereIsNoCarException("This Car quantity is 0");
            }
            int x = Cars[item.Id].Value;
            Cars[item.Id] = new KeyValuePair<Car, int>(item, --x);
        }
        #endregion

         static public int GetCarQtyById(Guid id)
        {
            if (!Cars.ContainsKey(id))
                throw new CarDoesNotExistException("Car with ID: " + id.ToString() + " does not exist");
            return Cars[id].Value;
        }

        #region IEnumerable Implementation
        public IEnumerator<Car> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
        #endregion
    }
}
