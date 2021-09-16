using System;

namespace Assignment4
{
    class Program
    {
        static int totalfactor = 1;
        static void Main(string[] args)
        {
            int count = 1;
            int i = 1;
            while (count <= 10000)
            {
                bool isPerfect = IsPerfectNumber(count);
                if (isPerfect && (totalfactor > 1))
                {
                    Console.WriteLine("perfect number {0} = {1}",i++, totalfactor);
                }
                totalfactor = 1;
                count++;
            }
            Console.WriteLine("\nend of program");
        }

        static bool IsPerfectNumber(int number)
        {
            int temp;
            int counter = 2;
            bool IsPerfect = false;

            while (counter <= (number -1))
            {
                temp = number % counter;
                if (temp == 0)
                {
                    totalfactor = totalfactor + counter;
                }
                counter++;
            }
            if ((totalfactor)==number)
            {
                IsPerfect = true;
            }
            else
            {
                IsPerfect = false;
            }
            return IsPerfect;
        }
    }
}
