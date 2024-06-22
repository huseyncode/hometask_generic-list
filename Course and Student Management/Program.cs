using System;
using Course_and_Student_Management;


namespace MainCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nCourse Management Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Display Students");
                Console.WriteLine("4. Search Student");
                Console.WriteLine("5. Count Total Students");
                Console.WriteLine("6. Count Students Above 18");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("Enter student age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter student PIN: ");
                        string pin = Console.ReadLine();
                        course.AddStudent(new Student { Name = name, Surname = surname, Age = age, PIN = pin });
                        break;

                    case "2":
                        Console.Write("Enter student PIN to remove: ");
                        string removePin = Console.ReadLine();
                        course.RemoveStudent(removePin);
                        break;

                    case "3":
                        Console.WriteLine("Students:");
                        course.DisplayStudents();
                        break;

                    case "4":
                        Console.Write("Enter student PIN to search: ");
                        string searchPin = Console.ReadLine();
                        course.SearchStudent(searchPin);
                        break;

                    case "5":
                        Console.WriteLine("Total Students: " + course.CountTotalStudents());
                        break;

                    case "6":
                        Console.WriteLine("Students above 18: " + course.CountStudentsAbove18());
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
