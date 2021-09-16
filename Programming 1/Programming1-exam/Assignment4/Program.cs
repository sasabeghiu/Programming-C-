using System;

namespace Assignment4
{
    class Program
    {
        static int IntegerDivision(int number1, int number2, int rest)
        {
            if (number1 % number2 == 0)
            {
                rest = 0;
            }
            else
            {
                rest = number1 / number2;
            }
            return rest;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numbers = 10;
            for (int i = 0;  i<=numbers;  i++)
            {
                
                int nr1 = rnd.Next(0, 50);
                int nr2 = rnd.Next(0, 5);
                int result = IntegerDivision(number1, number2, rest);
                Console.WriteLine("{0} / {1} = {2} ({3})", nr1, nr2, result, rest);
            }
        }
    }
}
