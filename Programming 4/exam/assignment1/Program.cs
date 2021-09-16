using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        private void Start()
        {
            //template pattern

            PrintHeader("[wooden house]");
            BaseHouse house1 = new WoodenHouse();
            house1.BuildHouse();

            Console.WriteLine();

            PrintHeader("[glass house]");
            BaseHouse house2 = new GlassHouse();
            house2.BuildHouse();

            Console.WriteLine();

            PrintHeader("[concrete house]");
            BaseHouse house3 = new ConcreteHouse();
            house3.BuildHouse();
        }

        private void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}
