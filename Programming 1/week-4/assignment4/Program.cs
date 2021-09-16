using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 20;
            int a = 1, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < length; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        } 
    }
}
