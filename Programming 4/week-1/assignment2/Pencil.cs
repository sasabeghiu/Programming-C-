using System;

namespace assignment2
{
    public class Pencil : IPencil
    {
        private int maxToWrite;       // number of characters to write with a sharpened pencil
        private int nrOfCharsWritten; // number of written characters

        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
            nrOfCharsWritten = 0;
        }

        public bool CanWrite
        {
            get
            {
                return nrOfCharsWritten < maxToWrite;
            }
        }

        public void Write(string message)
        {
            string word = "";
            foreach (char c in message)
            {
                if (!CanWrite)
                {
                    word += "#";
                }
                else
                {
                    word += c;
                }
                nrOfCharsWritten++;
            }
            Console.WriteLine(word);
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }
    }
}
