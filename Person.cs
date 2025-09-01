using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public Person(int id, string FullName, int Age)
        {
            Id = 0;
            FullName = FullName;
            Age = Age;


        }
        public abstract void Display();
    }
    public class Student : Person
    {
        public string Major { get; set; }
        public double GPA { get; set; }

        public Student(int id, string FullName, int Age, string Major, double GPA) : base(id, FullName, Age)
        {
            Major = Major;
            GPA = GPA;
        }

        public override void Display()
        {
            Console.WriteLine($"[Student] ID: {Id}, Name: {FullName}, Age: {Age}, Major: {Major}, GPA: {GPA}");
        }
        public void RegisterCourse(string courseName)
        {
            Console.WriteLine(FullName + "Registered in course" + courseName);
        }
        public void RegisterCourse(string courseName, int credits)
        {
            Console.WriteLine(credits);
        }
    }
    public class Professor : Person, ITeacher
    {
        public string department { get; set; }
        public double salary { get; set; }
        public Professor(int id, string FullName, int Age, string department, double salary) : base(id, FullName, Age)
        {
            department = department;
            salary = salary;
        }
        public override void Display()
        {
            Console.WriteLine($"[Student] ID: {Id}, Name: {FullName}, Age: {Age}, department: {department}, salary: {salary}");
        }

        public void TeachCourse(string courseName)
        {
            Console.WriteLine(courseName);
        }
    }
 

    }




