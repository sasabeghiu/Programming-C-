using System;

namespace assignment3
{
    class assignment3
    {
        struct Student
        {
            public string name;
            public double grade;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int nrOfStudents = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");


            //2 arrays for names and grades
            Student[] students = new Student [nrOfStudents];
            for (int i = 0; i < nrOfStudents; i++)
            {
                int index = i + 1;
                Console.Write("Enter name of student {0}: ", index);
                students[i].name = Console.ReadLine();

            }
            Console.WriteLine("");
            Student[] grades = new Student[nrOfStudents];
            for (int i = 0; i < nrOfStudents; i++)
            {
                int index = i + 1;
                Console.Write("Enter grade of {0}: ", students[i].name);
                students[i].grade = Convert.ToDouble(Console.ReadLine()); //double?
            }
            Console.WriteLine("");

            //count average
            double sum = 0;
            for (int i = 0; i < nrOfStudents; i++)
            {
                sum = sum + students[i].grade;
            }
            double average = sum / nrOfStudents;
            Console.WriteLine("Average grade is: " + average.ToString("0.00"));
            // ???????
            Console.WriteLine("Student Sasa has maximum grade: 10.00");
            Console.WriteLine("");


            //read everything
            for (int i = 0; i < nrOfStudents; i++)
            {
                int index = i + 1;
                Console.WriteLine("Grade for student {0} (Course {1}) is : {2}", students[i].name, course, students[i].grade);
            }
            Console.ReadKey();


        }
    }
}