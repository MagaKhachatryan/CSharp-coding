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
        private Dictionary<Guid,string> Cars =new Dictionary<Guid, string>();

        public void AddCar(Guid id,string model)
        {
            if(Cars.Keys.Contains(id))
            {
                throw new CarAlreadyExists("This Car already is in the list of gareage's machines");
            }

            this.Cars.Add(id,model);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(Guid id)
        {
            if(!Cars.Keys.Contains(id))
            {
                throw new CarDoesNotExist("This Car  isn't in the list of gareage's machines");
            }

            this.Cars.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Cars.GetEnumerator();
        }
    }
}
