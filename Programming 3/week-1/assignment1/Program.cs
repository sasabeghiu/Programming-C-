using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        public void Start()
        {
            Programmer programmer1 = new Programmer("Peter", Speciality.Csharp);
            Programmer programmer2 = new Programmer("Kevin", Speciality.Java);
            Programmer programmer3 = new Programmer("John", Speciality.Csharp);
            Programmer programmer4 = new Programmer("Susan", Speciality.Java);
            Programmer programmer5 = new Programmer("Emma");

            Team team = new Team();
            team.AddProgrammer(programmer1);
            team.AddProgrammer(programmer2);
            team.AddProgrammer(programmer3);
            team.AddProgrammer(programmer4);
            team.AddProgrammer(programmer5);
            team.PrintAllTeamMembers();

            Console.ReadLine();
        }
    }
}
