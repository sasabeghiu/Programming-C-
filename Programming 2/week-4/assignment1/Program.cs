using System;
using System.IO;

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
            Person person = new Person();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string filename = name + ".txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("Nice to see you again, {0}!", name);
                Console.WriteLine("We have the following information about you:");
                ReadPerson(filename);
            }
            else
            {
                Console.WriteLine("Welcome {0}!", name);
                person = ReadPerson();
                WritePerson(person, filename);
                Console.WriteLine("Your data is written to file.");
            }
            Console.ReadLine();
        }
        Person ReadPerson()
        {
            Person p = new Person();
            Console.Write("Enter your name: ");
            p.name = Console.ReadLine();
            Console.Write("Enter your city: ");
            p.city = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            p.age = int.Parse(age);
            return p;
        }
        void DisplayPerson(Person p)
        {
            Console.WriteLine("Name: {0}", p.name);
            Console.WriteLine("City: {0}", p.city);
            Console.WriteLine("Age : {0}", p.age);
        }
        void WritePerson(Person p, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(p.name);
            writer.WriteLine(p.city);
            writer.WriteLine(p.age);
            writer.Close();
        }
        Person ReadPerson(string filename)
        {
            Person p = new Person();
            StreamReader reader = new StreamReader(filename);
            p.name = reader.ReadLine();
            Console.WriteLine("Name: {0}", p.name);
            p.city = reader.ReadLine();
            Console.WriteLine("City: {0}", p.city);
            string age = reader.ReadLine();
            p.age = int.Parse(age);
            Console.WriteLine("Age : {0}", p.age);
            reader.Close();
            return p;
        }
    }
}
