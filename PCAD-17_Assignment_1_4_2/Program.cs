// Program:    PCAD_Project_1.4.2
// Date:       10 APR 2025
// Programmer: Thomas A. Morrison

using System;
using System.Globalization;
namespace PCAD_Project_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program instantiates an object 'Student', assigns data to its properties, and displays the data.\n");

            Student student1 = new Student();
            student1.StudentID = 1;
            student1.StudentFName = "Abel";
            student1.StudentLName = "Label";
            student1.StudentGrade = 'A';

            Student student2 = new Student();
            student2.StudentID = 2;
            student2.StudentFName = "Cain";
            student2.StudentLName = "Label";
            student2.StudentGrade = 'C';

            Console.WriteLine($"First student:\n  Student Number: {student1.StudentID}\n  First Name: {student1.StudentFName}\n  Last Name: {student1.StudentLName}\n  Grade: {student1.StudentGrade}\n");
            Console.WriteLine($"Second student:\n  Student Number: {student2.StudentID}\n  First Name: {student2.StudentFName}\n  Last Name: {student2.StudentLName}\n  Grade: {student2.StudentGrade}\n");
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }

        class Student 
        {
            private int studentID;
            public int StudentID { get; set; }

            private string studentFName;
            public string StudentFName { get; set; }

            private string studentLName;
            public string StudentLName { get; set; }

            private char studentGrade;
            public char StudentGrade { get; set; }
        }
    }
}

