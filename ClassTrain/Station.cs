using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    public class Station : IEnumerable
    {
        private List<Train> trains = new List<Train>();

        public IEnumerator GetEnumerator()
        {
            return trains.GetEnumerator();
        }

        public Station()
        {
            trains = new List<Train>();
        }
        public void AddTrain(Train t)
        {
            if (!trains.Contains(t))
            { trains.Add(t); }
        }

        public void RemoveTrain(Train t)
        {
            if (!trains.Contains(t))
            { trains.Remove(t); }
        }

        public  bool Contains(Train t)
        {
            return trains.Contains(t);
        }

        public void SortByArrivalTime()
        {
            trains.Sort();
        }
    }
}
