using System;

namespace assignment2
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
            //Declare a variable of type Person and fill all fields
            Person person1;
            person1.FirstName = "Alexandru";
            person1.LastName = "Beghiu";
            person1.Age = 21;
            person1.City = "Dublin";

            //array for 3 persons
            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = ReadPerson();
                Console.WriteLine();
            }
            for (int i = 0; i < people.Length; i++)
            {
                PrintPerson(people[i]);
            }
            Console.ReadLine();

        }
        //Method for Reading a person
        Person ReadPerson()
        {
            Person person;
            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.Gender = ReadGender("Enter gender (m/f): ");
            person.Age = ReadInt("Enter age: ");
            person.City = ReadString("Enter city: ");
            return person;
        }
        //Methods copied from assignment 0
        int ReadInt(string question)
        {
            Console.Write(question);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
        //Method that prints the given person
        void PrintPerson(Person p)
        {
            Console.Write("{0} {1} " ,p.FirstName, p.LastName);
            PrintGender(p.Gender);
            Console.WriteLine("");
            Console.WriteLine("{0} years old, {1}" ,p.Age, p.City);
            Console.WriteLine("");
        }
        //method for reading a gender
        GenderType ReadGender(string question)
        {
            Console.Write(question);
            string Gender = Console.ReadLine();
            GenderType gender = GenderType.Male;
            if (Gender =="m")
            {
                gender = GenderType.Male;
            }
            else if (Gender == "f")
            {
                gender = GenderType.Female;
            }
            return gender;
        }
        //method that prints m for male and f for female
        void PrintGender(GenderType gender)
        {
            if (gender == GenderType.Male)
            {
                Console.Write("(m)");
            }
            else if (gender == GenderType.Female)
            {
                Console.Write("(f)");
            }
        }
    }
}
