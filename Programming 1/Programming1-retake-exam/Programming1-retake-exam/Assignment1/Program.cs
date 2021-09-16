using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //read 2 numbers
            Console.Write("enter number 1: ");
            int nr1 = int.Parse(Console.ReadLine());
            Console.Write("enter number 2: ");
            int nr2 = int.Parse(Console.ReadLine());
            Console.Write("enter operator (+ - *): ");
            string operatoR = Console.ReadLine();
            int result = 0;
            if (operatoR == "+")
            {
                result = nr1 + nr2;
            }
            else if (operatoR == "-")
            {
                result = nr1 - nr2;
            }
            else
            {
                result = nr1 * nr2;
            }
            Console.WriteLine("\nresult = {0}", result);
            Console.ReadLine();
        }
    }
}
