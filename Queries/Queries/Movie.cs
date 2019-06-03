using System;
using System.Collections;

namespace Queries
{
    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        private int year;
        public int Year
        {
            get
            {
                //Console.WriteLine($"getting the year {this.year}");
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            yield return this.Year;
        }

        
        //public override string ToString()
        //{
        //    return $"{this.Year}, {this.Rating}, {this.Title}";
        //}
    }
}
