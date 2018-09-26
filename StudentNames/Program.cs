using System;
using System.Collections.Generic;
using System.IO;

namespace StudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line;
            int numberOfGrades = 0;
            StreamReader file = new StreamReader("C:\\Users\\melissa\\source\\repos\\StudentNames\\StudentNames\\TextFile1.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lines = line.Split(" ");
                numberOfGrades = lines.Length;
                string studentName = lines[0];
                Student newStudent = new Student(studentName, numberOfGrades);
                students.Add(newStudent);
            }
            foreach (Student newStudent in students)
            {
                if (newStudent.Grades >=7)
                    Console.WriteLine(newStudent.Name);
                
            }
            Console.ReadLine();
        }
    }
}
