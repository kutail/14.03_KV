using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03_KV
{
    public class Student
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public List<int> Grades { get; set; }
        public double AverageGrade
        {
            get { return Grades.Average(); } // не понял почему не работает в стандартной форме public double AverageGrade(){...};
        }
    }
}
