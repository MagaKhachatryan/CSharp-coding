using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ConsoleApplication1
{
    public class ComparePlaces : IComparer<Train>
    {
        public int Compare(Train t1, Train t2)
        {
            return t1.Place.CompareTo(t2.Place);
        }
    }


    public enum Place
    {
        Barekamutyun,
        Baghramyan,
        Yeritasardakan,
        Republic,
        Andranik,
        Davo
    }
    public class Train : IComparable<Train>
    {
        private readonly Guid ID = new Guid();        
        private Place place;
        public Place Place
          {
            get { return place; }
             private set { place = value; }
          }
         private DateTime startTime;
         public DateTime StartTime
        {
            get { return startTime; }
            private set { startTime = value; }
        }


         public Train(Place p, DateTime t)
         {
             Place = p;
             StartTime = t;
         }

         public bool Equals(object obj)
         {
             if (obj is Train)
             {
                 return ID == ((obj as Train).ID);
             }
             else return false;
         }


        public int CompareTo(Train t)
        {
            return StartTime.CompareTo(t.StartTime);
        }
     
    }
}
