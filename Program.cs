using School__System.Models;

namespace School__System
{
    public  class Program
    {
        static StudentManager studentManager = new StudentManager();
        static TeacherManager teacherManager = new TeacherManager();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("School Management System");
                Console.WriteLine("1. Manage Students");
                Console.WriteLine("2. Manage Teachers");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManageStudents();
                        break;
                    case 2:
                        ManageTeachers();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 3);
        }

        static void ManageStudents()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Manage Students");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        studentManager.ViewAllStudents();
                        Console.ReadLine(); // Pause
                        break;
                    case 3:
                        RemoveStudent();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }

        static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Date of Birth (YYYY-MM-DD): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Student student = new Student(id, firstName, lastName, dob);
            studentManager.AddStudent(student);
            Console.WriteLine("Student added successfully!");
            Console.ReadLine(); // Pause
        }

        static void RemoveStudent()
        {
            Console.Write("Enter Student ID to remove: ");
            int id = int.Parse(Console.ReadLine());
            studentManager.RemoveStudent(id);
            Console.ReadLine(); // Pause
        }

        static void ManageTeachers()
        {
            Console.Clear();
            Console.WriteLine("Manage Teachers");
            Console.WriteLine("1. Add Teacher");
            Console.WriteLine("2. View All Teachers");
            Console.WriteLine("3. Back to Main Menu");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTeacher();
                    break;
                case 2:
                    teacherManager.ViewAllTeachers();
                    Console.ReadLine(); // Pause
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void AddTeacher()
        {
            Console.Write("Enter Teacher ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Subject: ");
            string subject = Console.ReadLine();

            Teacher teacher = new Teacher(id, firstName, lastName, subject);
            teacherManager.AddTeacher(teacher);
            Console.WriteLine("Teacher added successfully!");
            Console.ReadLine();
        }
    }
}

