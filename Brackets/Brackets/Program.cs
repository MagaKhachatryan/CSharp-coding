using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string A = Console.ReadLine();
            Console.WriteLine(Convert.ToString(BracketBalance(A)));
            Console.ReadKey();
        }
        static public bool BracketBalance(string Arr)
        {
            char x;
            Stack<char> St = new Stack<char>();
            for(int i=0;i<Arr.Length;++i)
            {
                if(Arr[i]=='(' || Arr[i]=='{' || Arr[i]=='[')
                {
                    St.Push(Arr[i]);
                    continue;
                }

                if (St.Count == 0)
                    return false;

                if(Arr[i]==')')
                 {
                    x = St.Pop();
                    if(x=='{'  ||  x=='[')
                    {
                        return false;
                    }
                 }
                if (Arr[i] == '}')
                {
                    x = St.Pop();
                    if (x == '(' || x == '[')
                    {
                        return false;
                    }
                }

                if (Arr[i] == ']')
                {
                    x = St.Pop();
                    if (x == '{' || x == '(')
                    {
                        return false;
                    }
                }

            }
            if(St.Count!=0)
            {
                return false;
            }
            return true;
        }
    }
}
