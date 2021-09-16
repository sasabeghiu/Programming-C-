using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }

        void Start()
        {
            ATMMachine machine = new ATMMachine(2000);
            machine.SetAmountInMachine(2000);
            string command = "";
            while (command != "stop")
            {
                Console.Write("Please enter your command: ");
                Console.ForegroundColor = ConsoleColor.Green;
                command = Console.ReadLine();
                Console.ResetColor();

                if (command == "insert card")
                {
                    machine.InsertCard();
                }
                else if (command == "reject card")
                {
                    machine.RejectCard();
                }
                else if (command == "enter pincode")
                {
                    Console.WriteLine($"Please enter your pincode: 1234");
                    machine.EnterPincode(1234);

                }
                else if (command == "withdraw cash")
                {
                    Console.WriteLine($"Please enter amount of cash: 1500");
                    machine.WithdrawCash(1500);
                }
                else
                {
                    Console.WriteLine("entered unknown command");
                    Console.WriteLine();
                }
            }
        }
    }
}
