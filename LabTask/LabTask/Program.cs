using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Student
    {
        private String name;
        private String id;
        private String dept;
        private float cgpa;

        public Student(String Name, String ID, String Dept, float cgpa)
        {
            name = Name;
            id = ID;
            dept = Dept;
            this.cgpa = cgpa;
        }

        public void showinfo()
        {
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Id: " +id);
            Console.WriteLine("Department: " +dept);
            Console.WriteLine("cgpa: " +cgpa);
        }
    }

    class Triangle

    {
        private int x;
        private int y;
        private int z;

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void showinfo()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(y);
        }

        public void Testtringle()
        {
            if (x == y)
            {
                if (y == z)
                {
                    Console.WriteLine(" the triangle is equilateral");
                }
                else if (y != z)
                {
                    Console.WriteLine("THE TRIANGLE IS isosceles");
                }

            }
            else
            {
                Console.WriteLine("scalene");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Marium", "18-39059-3", "CSE", 3.73F);
            s1.showinfo();
            Console.WriteLine();
            Triangle t1 = new Triangle(5, 5, 6);
            t1.showinfo();
            t1.Testtringle();
        }
    }
}