using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        /* public static void concat1(String s1)
         {

             // taking a string which is to be Concatenate 
             string st = "Khachatryan";
             s1 = String.Concat(s1, st);
         }

         // Concatenates to StringBuilder 
         public static void concat2(StringBuilder s2)
         {
             s2.Append("Khachatryan");
         }*/

        public static void Main()
        {
            /*//theDIFFERENCE
            string s1 = "Maga";
            concat1(s1); // s1 is not changed 
            Console.WriteLine("Using String Class: " + s1);

            StringBuilder s2 = new StringBuilder("Maga");
            concat2(s2); // s2 is changed 
            Console.WriteLine("Using StringBuilder Class: " + s2);*/

            /* //FUNCTION_ToSTRING
             StringBuilder str= new StringBuilder("Yellow is cool");
             Console.WriteLine("String contains = "+ str.ToString());*/
            /*//COPY_TO
           StringBuilder str= new StringBuilder("123456789");
           char[] destination = new char[15];
           str.CopyTo(5, destination, 0, 3);
           // Displaying String 
           Console.Write("The Copied String in destination Variable is: ");
           Console.WriteLine(destination);*/

            /* //LENGTH
             StringBuilder str = new StringBuilder("MissLIGHT");
             // print string 
             Console.WriteLine("String = "+ str.ToString());
             // get length of StringBuilder object 
             int length = str.Length;
             // print length 
             Console.WriteLine("length of String = " + length);*/

            /* //EQUALITY
             StringBuilder st1 = new StringBuilder("Interesting life");
             StringBuilder st2 = new StringBuilder("Interesting lie");
             Console.WriteLine(st1.Equals(st2));*/


            /* // ENSURE_CAPACITY
             StringBuilder str = new StringBuilder();
             //by default capacity is 16
             Console.WriteLine("Before EnsureCapacity method capacity=" + str.Capacity);
             str.EnsureCapacity(18);

             Console.WriteLine("After EnsureCapacity method capacity =" + str.Capacity);*/


            StringBuilder str = new StringBuilder("ForIfAnd");
            Console.WriteLine("String is " + str.ToString());
            // go through string 
            // and print every Character 
            for (int i = 0; i < str.Length; i++)
            {
                // get char at position i 
                char ch = str[i];
                Console.WriteLine("Char at position " + i + " is " + ch);
            }
        }
    }
}
