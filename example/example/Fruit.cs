using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    public class Fruit
    {
        private int[] Arr = new int[25];
        public int this[int i]
        {
            get { return Arr[i]; }
            set { Arr[i] = value; }
        }
        
    }
}
