using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathServer;

namespace MathServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            TCP server = new TCP();
            server.SendResult();
        }
    }
}
