using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_and_Student_Management
{
    public class Course
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            if (!students.Exists(s => s.PIN == student.PIN))
            {
                students.Add(student);
                Console.WriteLine($"Student {student.Name} {student.Surname} added.");
            }
            else
            {
                Console.WriteLine($"Student with PIN {student.PIN} already exists.");
            }
        }

        public void RemoveStudent(string pin)
        {
            var student = students.FirstOrDefault(s => s.PIN == pin);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine($"Student with PIN {pin} removed.");
            }
            else
            {
                Console.WriteLine($"Student with PIN {pin} not found.");
            }
        }

        public void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
        }

        public void SearchStudent(string pin)
        {
            var student = students.FirstOrDefault(s => s.PIN == pin);
            if (student != null)
            {
                Console.WriteLine($"Found student: {student.Name} {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
            else
            {
                Console.WriteLine($"Student with PIN {pin} not found.");
            }
        }

        public int CountTotalStudents()
        {
            return students.Count;
        }

        public int CountStudentsAbove18()
        {
            return students.Count(s => s.Age > 18);
        }
    }
}
