using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRolling
{
    class Program
    {
        /// <summary>
        /// this is Main for operating die rolling events 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var die = new Die();
            die.TwoSequentialFours += OnTwoSEquentialFours;
            die.SumIsGreatThanTwenty += OnSumIsGreatThanTwenty;
            die.Rolling();
            Console.ReadKey();
        }

        static public void OnTwoSEquentialFours()
        {
            Console.WriteLine("Two fours was met by the result of rolling");
        }

        static public void OnSumIsGreatThanTwenty()
        {
            Console.WriteLine("The Sum of Five Sequance Numbers on rolled dies is great than 20");
        }
    }
}

