using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the numbers and convert them
            Console.Write("Enter first number: ");
            string value1 = Console.ReadLine();
            int nr1 = Int32.Parse(value1);
            Console.Write("Enter second number: ");
            string value2 = Console.ReadLine();
            int nr2 = Int32.Parse(value2);
            Console.Write("Enter third number: ");
            string value3 = Console.ReadLine();
            int nr3 = Int32.Parse(value3);

            //calculate and display sum,average,product
            double sum = nr1 + nr2 + nr3;
            Console.WriteLine("sum = " +sum);
            double average = sum / 3;
            Console.WriteLine("average = " + average.ToString("0.00")); //display it as 0.00
            int product = nr1 * nr2 * nr3;
            Console.WriteLine("product = " + product);

            //find out the highest and lowest number and display
            if (nr1 > nr2 && nr1 > nr3)
            {
                Console.WriteLine("highest: " + nr1);
            }
            else if (nr2>nr1 && nr2>nr3)
            {
                Console.WriteLine("highest: " + nr2);
            }
            else
            {
                Console.WriteLine("highest: " + nr3);
            }

            if (nr1 < nr2 && nr1 < nr3)
            {
                Console.WriteLine("lowest: " + nr1);
            }
            else if (nr2 < nr1 && nr2 < nr3)
            {
                Console.WriteLine("lowest: " + nr2);
            }
            else
            {
                Console.WriteLine("lowest: " + nr3);
            }

            Console.ReadLine();
        }
    }
}
