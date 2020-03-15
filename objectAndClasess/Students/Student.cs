using System;
using System.Collections.Generic;
using System.Text;

namespace Students1
{
    class Student
    {
        public Student(string name, string lastName, double grade)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
