using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class Student
    {
        public string Name;
        public Guid ID { get; private set; }
        public Dictionary<string,double> TestScores;
    }
}
