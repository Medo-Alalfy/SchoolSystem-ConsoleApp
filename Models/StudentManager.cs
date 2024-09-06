using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School__System.Models
{
    public  class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(int studentID)
        {
            var student = students.Find(s => s.StudentID == studentID);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void ViewAllStudents()
        {
            foreach (var student in students)
            {
                student.PrintStudentDetails();
            }
        }

        public Student GetStudentById(int studentID)
        {
            return students.Find(s => s.StudentID == studentID);
        }
    }
}
