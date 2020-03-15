using System;
using System.Collections.Generic;
using System.Linq;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string currentStudent = Console.ReadLine();

                if (currentStudent == "end")
                {
                    break;
                }

                string[] currentStudentArgs = currentStudent.Split(" ");

                string firstName = currentStudentArgs[0];
                string lastName = currentStudentArgs[1];
                int age = int.Parse(currentStudentArgs[2]);
                string homeTown = currentStudentArgs[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                students.Add(student);
            }

            string cityOnWhichToSort = Console.ReadLine();

            List<Student> filteredStudent = students
                .Where(x => x.HomeTown == cityOnWhichToSort)
                .ToList();

            foreach (Student student in filteredStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} " +
                      $"years old.");
            }
        }
    }
}
