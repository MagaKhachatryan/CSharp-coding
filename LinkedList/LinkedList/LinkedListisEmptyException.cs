using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListisEmptyException:SystemException
    {
        public LinkedListisEmptyException(string msg)
            :base(msg)
        {

        }
    }
}
