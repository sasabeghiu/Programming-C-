using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            string message = "";
            Pencil pencil = new Pencil(20);
            PencilSharpener sharpener = new PencilSharpener();

            while (message != "stop")
            {
                Console.Write("Enter a word: ");
                message = Console.ReadLine();

                if (message == "sharpen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("sharpening the pencil...");
                    sharpener.Sharpen(pencil);
                    message = "";
                    Console.ResetColor();
                }
                else if(message=="stop")
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    pencil.Write(message);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("end of program...");
        }
    }
}
