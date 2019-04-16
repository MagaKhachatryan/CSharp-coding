using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DieRolling1;

namespace ExaminingTheDieRolling
{
    class Program
    {
        /// <summary>
     /// this is Main for operating die rolling events 
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Die die = new Die();
            die.TwoSequentialFours += OnTwoSEquentialFours;
        }

        static public void OnTwoSEquentialFours()
        {
            Console.WriteLine("Two fours was met by the result of rolling");
        }
    }
}
