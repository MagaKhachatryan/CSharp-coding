using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        static void Main(string[] args)
        {
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight",   Rating = 8.9f, Year = 2008 },
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2008 },
                new Movie { Title = "Casablanca",        Rating = 8.5f, Year = 1942 },
                new Movie { Title = "Star Wars V",       Rating = 8.7f, Year = 1980 }
            };

            //var query = movies.Where(m => m.Year > 1000).OrderBy(r => r.Rating).
            //    Select(m => m);

            //var query2 = from m in movies
            //             where m.Year > 2000
            //             orderby m.Rating
            //             select m.Title;                   


            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Title}");
            //}


            var query3 = movies.Select(m => m.Year);
            var query4 = movies.GroupBy(m => m.Year);
            var query5 = movies.Select((m) => new { m.Title, m.Year });


            foreach (var item in query4)
            {
                foreach (var a in item)
                {
                    Console.WriteLine(a.Rating);
                }
                Console.WriteLine($"Ext: {item}");
            }


            //var oldMovies = movies.Where(m => m.Year < 2000);
            //Console.WriteLine(movies.MyCount());
            //Console.WriteLine(MyLinq.MyCount(movies));

            //Movie myMovie = new Movie() { Year = 1999, Rating= 3.0f, Title= "some title"};
            //Console.WriteLine(myMovie);
            //foreach (var item in myMovie)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //var enumerator = oldMovies.GetEnumerator();
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Title);
            //}

            //foreach (var item in oldMovies)
            //{
            //    Console.WriteLine(item.Title);
            //}
            Console.ReadLine();
        }
    }
}
