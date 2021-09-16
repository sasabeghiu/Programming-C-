using System;

namespace assignment1
{
    public class Logger
    {
        private int numberOfLines;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLines = 0;
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }

        public void Log(string system, string text)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{system}] {text}");

        }
    }
}
