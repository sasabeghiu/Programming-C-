using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Team
    {
        List<Programmer> programmers = new List<Programmer>();

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer programmer in programmers)
            {
                programmer.Print();
            }
        }

        public Team()
        {
        }
    }
}
