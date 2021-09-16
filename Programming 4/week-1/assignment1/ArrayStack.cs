using System;
using System.Linq;

namespace assignment1
{
    public class ArrayStack : IStack
    {
        private int[] items;
        private int count;

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public ArrayStack(int maxItems)
        {
            items = new int[maxItems];
            count = 0;
        }

        public void Push(int value)
        {
            if (count == items.Length)
            {
                throw new Exception("Full Stack!");
            }
            items[count] = value;
            count++;
        }

        public int Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Empty Stack!");
            }
            count--;
            return items[count];
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
