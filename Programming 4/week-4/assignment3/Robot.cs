using System;

namespace assignment3
{
    public class Robot
    {
        public string Person { get; set; }
        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public void MoveByPerson(string person)
        {
            this.Person = person;
            Console.WriteLine($"Robot is moved by {Person}");
        }

        public void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }
    }
}
