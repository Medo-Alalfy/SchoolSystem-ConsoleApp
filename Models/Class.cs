using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__System.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public Teacher ClassTeacher { get; set; }
        public List<Student> Students { get; set; }

        public Class(int id, string name, Teacher teacher)
        {
            ClassID = id;
            ClassName = name;
            ClassTeacher = teacher;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void PrintClassDetails()
        {
            Console.WriteLine($"Class: {ClassName}, Teacher: {ClassTeacher.FirstName} {ClassTeacher.LastName}");
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                student.PrintStudentDetails();
            }
        }
    }
}
