using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class StudentCatalog
    {
        public  Dictionary<int, Student> StudentsList = new Dictionary<int, Student>();
        /// <summary>
        /// </summary>
        /// Add a single student to the catalog.
        public void AddStudent(Student aStudent)
        {
            if (!StudentsList.Keys.Contains(aStudent.ID))
            {
                StudentsList.Add(aStudent.ID, aStudent);
            }
        }
        /// <summary>
        /// Given an id, return the student with that id.
        /// If no student exists with the given id, return null.
        /// </summary>
        public Student GetStudent(int id)
        {
            if (StudentsList.ContainsKey(id))
            { return StudentsList[id]; }
            return null;
        }
        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        public double GetAverageForStudent(int id)
        {
            if (StudentsList.ContainsKey(id))
            {
                double av = 0;
                foreach (string name in StudentsList[id].TestScores.Keys)
                {
                    av += StudentsList[id].TestScores[name];
                }
                return av / StudentsList[id].TestScores.Count;
            }
            return -1;
        }
        /// <summary>
        /// Returns the total test score average for ALL students in the catalog.
        /// Note that only students with a "real" score average (i.e. NOT -1) should
        /// be included in the calculation of the average.
        /// </summary>
        public double GetTotalAverage()
        {
            double Average = 0;
            foreach (int g in StudentsList.Keys)
            {
                
                Average += GetAverageForStudent(g);
            }
            return Average/StudentsList.Count;
        }

        /// <summary>
        /// Get top three students who have the highest average score.
        /// If no student returns empty list.
        /// </summary>
        public List<Student> GetTopThreeStudents()
        {
            var TopStudents = new List<Student>();
            var StudentsAverages = new Dictionary<double, Student>();
            foreach (var g in StudentsList.Keys)
            {
                if(GetAverageForStudent(g)!=-1)
                {
                    StudentsAverages.Add(GetAverageForStudent(g),StudentsList[g]);
                }
            }

            StudentsAverages.OrderBy(a => a.Key);
            var Students = StudentsAverages.Values.ToList<Student>();
            for(int i=0;i<3;++i)
            {
                TopStudents.Add(Students[i]);
            }
            return TopStudents;
        }
    }
}