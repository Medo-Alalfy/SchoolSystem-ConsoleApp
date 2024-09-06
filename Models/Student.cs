using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__System.Models
{
    public  class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Grade> Grades { get; set; }

        public Student(int id, string firstName, string lastName, DateTime dob)
        {
            StudentID = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Grades = new List<Grade>();
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"ID: {StudentID}, Name: {FirstName} {LastName}, DOB: {DateOfBirth.ToShortDateString()}");
        }
    }
}
