using System;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            List<Course> gradeList;
            gradeList = ReadGradeList(3);
            DisplayGradeList(gradeList);
            Console.ReadLine();
        }
        string ReadString(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ResetColor();
            return name;
        }
        int ReadInt(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            int value = int.Parse(Console.ReadLine());
            Console.ResetColor();
            return value;
        }
        PracticalGrade ReadPracticalGrade(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            int grade = int.Parse(input);
            Console.ResetColor();
            return (PracticalGrade)grade;
        }
        void DisplayPracticalGrade(PracticalGrade practical)
        {
            for (PracticalGrade i = PracticalGrade.None; i <= PracticalGrade.Good; i++)
            {
                Console.Write($"{(int)i}. {i} ");//0.none 1.absent 2.insufficient 3.sufficient 4.good
            }
            Console.WriteLine();
        }
        Course ReadCourse(string question)
        {
            Console.WriteLine(question);
            Course course = new Course();
            course.Name = ReadString("Name of the course: ");
            course.Grade = ReadInt($"Grade for {course.Name}: ");
            DisplayPracticalGrade(course.Practical);
            course.Practical = ReadPracticalGrade($"Practical grade for {course.Name}: ");
            Console.WriteLine();
            return course;
        }
        void DisplayCourse(Course course)
        {
            Console.WriteLine("{0}  : {1}  {2}", course.Name, course.Grade, course.Practical);
        }
        List<Course> ReadGradeList(int nrOfCourses)
        {
            List<Course> gradeList = new List<Course>();
            for (int i = 0; i < nrOfCourses; i++)
            {
                gradeList.Add(ReadCourse("Enter a course"));
            }
            return gradeList;
        }
        void DisplayGradeList(List<Course> gradeList)
        {
            foreach (Course course in gradeList)
            {
                DisplayCourse(course);
            }
            int retake = 0;
            int counter = 0;
            foreach (Course course in gradeList)
            {
                if (!course.Passed())
                {
                    retake++;
                }
            }
            foreach (Course course in gradeList)
            {
                if (course.CumLaude())
                {
                    counter++;
                }
            }
            if (retake > 0)
            {
                Console.WriteLine("Too bad, you did not graduate, you got {0} retakes.", retake);
            }
            else if (counter == 3)
            {
                Console.WriteLine("Congratulations, you graduated Cum Laude!");
            }
            else
            {
                Console.WriteLine("Congratulations, you graduated!");
            }
        }

    }
}
