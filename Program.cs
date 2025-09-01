using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Ali", 20, "Computer Science", 3.8);
            s1.Display();
            s1.RegisterCourse("OOP");
            s1.RegisterCourse("Database", 3);

            Console.WriteLine();

            Professor p1 = new Professor(2, "Dr.Hassan", 45, "Computer Science", 15000);
            p1.Display();
            p1.TeachCourse("Data Structures");

            Console.WriteLine();

            Person personRef;

            personRef = s1;
            personRef.Display();

            personRef = p1; 
            personRef.Display();
        }
    }
}
