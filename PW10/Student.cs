using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW10
{
    class Student : IStudent
    {
        public int[] Grades { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public double GetAvgGrade()
        {
            return (double)Grades.Sum() / Grades.Length;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
