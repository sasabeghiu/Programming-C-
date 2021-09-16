using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter text> ");
            string input = Console.ReadLine();

            int noOfCommas = 0, noOfSemiColons = 0, noOfFullStops = 0;

            SearchText(input, out noOfCommas, out noOfSemiColons, out noOfFullStops);

            Console.WriteLine("result: {0} full stops, {1} commas, {2} semicolons", noOfFullStops, noOfCommas, noOfSemiColons);
            Console.ReadKey();
        }

        static void SearchText(string text, out int noOfCommas, out int noOfSemiColons, out int noOfFullStops)
        {
            noOfCommas = 0;
            noOfFullStops = 0;
            noOfSemiColons = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('.'))
                {
                    noOfFullStops++;
                }
                else if (text[i].Equals(','))
                {
                    noOfCommas++;
                }
                else if (text[i].Equals(';'))
                {
                    noOfSemiColons++;
                }
            }
        }
    }
}
