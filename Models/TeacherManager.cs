using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace School__System.Models
{
    public  class TeacherManager
    {
        private List<Teacher> teachers = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void ViewAllTeachers()
        {
            foreach (var teacher in teachers)
            {
                teacher.PrintTeacherDetails();
            }
        }
    }
}
