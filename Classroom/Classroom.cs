using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251.Classroom
{
    internal class Classroom
    {
        private string name;
        private List<Student> students;

        public Classroom(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public int GetPassedAmount()
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (student.GetAverage() >= 13)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetFailedAmount()
        {
            return students.Count - GetPassedAmount();
        }

        public List<Student> GetPassedStudents()
        {
            List<Student> s = new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetAverage() >= 13)
                {
                    s.Add(student);
                }
            }
            return s;
        }

        public List<Student> GetFailedStudents()
        {
            List<Student> s = new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetAverage() < 13)
                {
                    s.Add(student);
                }
            }
            return s;
        }

        public float GetAverage()
        {
            float sum = 0;
            foreach (Student student in students)
            {
                sum += student.GetAverage();
            }
            return sum / students.Count;
        }

    }
}
