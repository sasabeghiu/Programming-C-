using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    //Creating a struct Person in a separate file
    struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        //added a new field with the options male and female (for that created a enum)
        public GenderType Gender;
        public string City;
    }
    public enum GenderType
    {
        Male, Female
    }
}
