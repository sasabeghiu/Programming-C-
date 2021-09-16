using System;

namespace assignment0
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
            int value = ReadInt("Enter a value: ");
            Console.WriteLine("You entered {0}.", value);

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", age);
           
            string name = ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}.", name);

            Console.ReadKey();
        }
        int ReadInt(string question)
        {
            Console.Write(question);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        int ReadInt(string question, int min, int max)
        {
            int age = 0;
            do
            {
                age = ReadInt(question);
            }
            while
            (age < 0 || age > 120);
            return age;
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
    }
}
