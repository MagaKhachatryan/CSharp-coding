using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var list = new LinkedListofNode();
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(9);
            foreach (var item in list)
            {
                Console.WriteLine(item.data);
            }

        }
    }
}
