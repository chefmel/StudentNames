using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNames
{
    public class Student
    {
        public string Name { get; set; }
        public int Grades { get; set; }

        public Student(string name, int grades)
        {
            Name = name;
            Grades = grades;
        }
     }
}
