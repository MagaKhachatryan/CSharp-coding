using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesandStrings
{
    public class OnlineAttendance
    {
        public event Action<string> InvalidNames;
        List<string> InputedNames = new List<string>();
        public void  InputProcess()
        {
            var random = new Random();
            for(int i=0;i<random.Next(0,9);++i)
            {
                InputedNames.Add(Console.ReadLine());
                if(InvalidNames!=null && (InputedNames[i]=="jack" || InputedNames[i] == "mathwe" || InputedNames[i] == "steven"))
                {
                    this.InvalidNames(InputedNames[i]);
                }
            }
        }
    }
}
