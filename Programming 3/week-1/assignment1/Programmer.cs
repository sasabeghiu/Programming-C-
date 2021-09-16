using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Programmer
    {
        public string name;
        public Speciality speciality;

        public Programmer(string name)
            :this(name, Speciality.Unknown)
        {

        }

        public Programmer(string name, Speciality spec)
            
        {
            this.name = name;
            speciality = spec;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Specialty: {speciality}");
        }
    }
}
