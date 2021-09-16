using System;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            Console.Write("Enter weight (kg): ");
            string value1 = Console.ReadLine();
            double kg = double.Parse(value1);
            Console.Write("Enter length (cm): ");
            string value2 = Console.ReadLine();
            double cm = double.Parse(value2);
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            //math
            double bmi = kg / ((cm / 100) * (cm / 100));
            double m1 = ((cm / 100) * (cm / 100)) * 20;
            double m2 = ((cm / 100) * (cm / 100)) * 25;
            double f1 = ((cm / 100) * (cm / 100)) * 19;
            double f2 = ((cm / 100) * (cm / 100)) * 24;

            //display and if for genders
            Console.WriteLine();
            Console.WriteLine("bmi-value: " + bmi.ToString("0.0"));

            if (gender == "male")
            {
                Console.WriteLine("normal bmi-values (min .. max): 20 .. 25");
                Console.WriteLine("healthy weight range: {0} .. {1}", m1.ToString("0.0"), m2.ToString("0.0"));
            }
            else if (gender == "female")
            {
                Console.WriteLine("normal bmi-values (min .. max): 19 .. 24");
                Console.WriteLine("healthy weight range: {0} .. {1}", f1.ToString("0.0"), f2.ToString("0.0"));
            }
            else
            {
                Console.WriteLine("enter male or female");
            }

            Console.ReadLine();
        }
    }
}
