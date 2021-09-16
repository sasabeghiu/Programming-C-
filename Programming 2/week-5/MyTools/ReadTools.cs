using System;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            Console.Write(question);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        public static int ReadInt(string question, int min, int max)
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
        public static string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
    }
}
