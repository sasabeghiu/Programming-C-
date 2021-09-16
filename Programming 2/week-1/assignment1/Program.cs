using System;

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
            PrintMonths();
            Console.WriteLine();
            Month Month = ReadMonth("Enter a month number: ");
            Console.Write("{0} => ", (int)Month);
            PrintMonth(Month);
            Console.ReadKey();
        }
        void PrintMonth(Month month)
        {
            Console.WriteLine(month);
        }
        void PrintMonths()
        {
            for (Month i = Month.January; i <= Month.December; i++)
            {
                Console.Write(string.Format(" {0,2}.", (int)i));
                PrintMonth(i);
            }
        }
        Month ReadMonth(string question)
        {
            int monthNumber = 0;
            bool validMonth = false;
            while (validMonth == false)
            {
                Console.Write(question);
                string input = Console.ReadLine();
                monthNumber = int.Parse(input);
                if (Enum.IsDefined(typeof(Month), monthNumber))
                {
                    validMonth = true;
                }
                else
                {
                    Console.WriteLine("{0} is not a valid value.", monthNumber);
                }
            }
            
            Month month = (Month)int.Parse(monthNumber.ToString());
            return month;
        }
    }
}
