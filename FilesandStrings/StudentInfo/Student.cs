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
        public readonly int ID;
        public Dictionary<string,double> TestScores=new Dictionary<string, double>();

        public Student(int id, string name)
        {
            this.Name = name;
            this.ID = id;
        }
        public void AddTestResult(string subject,double score)
        {
            
            TestScores.Add(subject, score);
          /*  if (!TestScores.ContainsKey(subject))
            {
                TestScores.Add(subject, score);
            }*/
        }


    }
}
