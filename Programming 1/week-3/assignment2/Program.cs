using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4):");
            string number = Console.ReadLine();
            string txt = "";
            
            switch(number)
            {
                case "1":
                    txt = "clubs";
                    break;
                case "2":
                    txt = "diamonds";
                    break;
                case "3":
                    txt = "hearts";
                    break;
                case "4":
                    txt = "spades";
                    break;
                default:
                    txt = "Incorrect number!";
                    break;
            }
            Console.WriteLine(txt);
            Console.ReadLine();
        }
    }
}
