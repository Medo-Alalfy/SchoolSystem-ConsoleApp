using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__System.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Teacher(int id, string firstName, string lastName, string subject)
        {
            TeacherID = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public void PrintTeacherDetails()
        {
            Console.WriteLine($"ID: {TeacherID}, Name: {FirstName} {LastName}, Subject: {Subject}");
        }
    }
}
