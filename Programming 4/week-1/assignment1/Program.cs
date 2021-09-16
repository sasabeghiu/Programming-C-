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
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
        }

        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = rnd.Next(1, 100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: { stack.Count}");
            }
        }

        void CheckValues(IStack stack)
        {
            Console.WriteLine();
            int input = 1;

            while (input != 0)
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());
                bool containts = stack.Contains(input);
                if (containts)
                {
                    Console.WriteLine($"stack contains value {input}");
                }
                else
                {
                    Console.WriteLine($"stack does not contain value {input}");
                }
            }
            Console.WriteLine();
        }

        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }
    }
}
