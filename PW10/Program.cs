using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Томас",
                FullName = "Шелби",
                Grades = new int[] {5,3,5,5}
            };
            Console.WriteLine(student.Grades[2]);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.FullName);
            Console.WriteLine(student.GetAvgGrade());

            Console.ReadKey();
        }
    }
}
