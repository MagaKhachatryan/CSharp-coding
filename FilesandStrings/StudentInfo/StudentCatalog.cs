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
        private Dictionary<Guid, Student> students = new Dictionary<Guid, Student>();
        /// <summary>
        /// </summary>
        /// Add a single student to the catalog.
        public void AddStudent(Student aStudent)
        {
            if (!students.Keys.Contains(aStudent.ID))
            {
                students.Add(aStudent.ID, aStudent);
            }
        }
        /// <summary>
        /// Given an id, return the student with that id.
        /// If no student exists with the given id, return null.
        /// </summary>
        public Student GetStudent(Guid id)
        {
            if (students.ContainsKey(id))
            { return students[id]; }
            return null;
        }
        /// <summary>
        /// Given an id, return the score average for the student with that id.
        /// If no student exists with the given id, return -1.
        /// </summary>
        public double GetAverageForStudent(Guid id)
        {
            if (students.ContainsKey(id))
            {
                double av = 0;
                foreach (string name in students[id].TestScores.Keys)
                {
                    av += students[id].TestScores[name];
                }
                return av / students[id].TestScores.Count;
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
            foreach (Guid g in students.Keys)
            {
                
                Average += GetAverageForStudent(g);
            }
            return Average/students.Count;
        }

        /// <summary>
        /// Get top three students who have the highest average score.
        /// If no student returns empty list.
        /// </summary>
        public List<Student> GetTopThreeStudents()
        {
            var TopStudents = new List<int>();
            foreach(Guid g in students.Keys)
            {
                GetAverageForStudent(g);
            }
        }
    }
}