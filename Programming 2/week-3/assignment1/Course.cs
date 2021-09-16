using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Course
    {
        public string Name;
        public int Grade;
        public PracticalGrade Practical;
        public bool Passed()
        {
            bool passed = true;
            if (Grade < 55 || (Practical < PracticalGrade.Sufficient))
            {
                passed = false;
            }
            return passed;
        }
        public bool CumLaude()
        {
            bool cumLaude = true;
            if (Grade < 80 || (Practical < PracticalGrade.Good))
            {
                cumLaude = false;
            }
            return cumLaude;
        }
    }
    public enum PracticalGrade
    {
        None, Absent, Insufficient, Sufficient, Good
    }
}
