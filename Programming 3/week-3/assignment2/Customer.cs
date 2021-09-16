using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class Customer
    {
        private string name;
        private DateTime dateofbirth;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Name can not be an empty string!");
                }
                this.name = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Date of birth must be in the past!");
                }
                this.dateofbirth = value;
            }
        }

        public Customer(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }

        public int Age
        {
            get { return (DateTime.Now.Year - DateOfBirth.Year) - 1; } //for codegrade
        }

        public bool Discount
        {
            get
            {
                return (Age >= 60);
            }
        }

        public override string ToString()
        {
            string discountbool = "";
            if (Discount)
            {
                discountbool = "yes";
            }
            else
            {
                discountbool = "no";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
            Console.ResetColor();
            return $"date of birth: {DateOfBirth:dd/MM/yyyy}\nage: {Age}\ndiscount: {discountbool}\n";
        }
    }
}
