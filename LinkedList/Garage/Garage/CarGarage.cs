using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class CarGarage:IEnumerable
    {
        private  Dictionary<Guid, string> Cars = new Dictionary<Guid, string>();
        public void AddnewCar(Car car)
        {
            if(Cars.Keys.Contains(car.id))
            {
                throw new CarAlreadyExists("This car already exsists in your dictionary");
            }
            else
            {
                Cars.Add(car.id, car.Model);
            }
        }

        public void DeltetheCar(Car car)
        {
            if (!Cars.Keys.Contains(car.id))
            {
                throw new CarDoesNotExsist("This Car does not excisis in your dictionary");
            }
            else
                Cars.Remove(car.id);
        }

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
    }
}
