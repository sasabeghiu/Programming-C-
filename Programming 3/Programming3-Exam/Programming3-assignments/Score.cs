using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    public class Score
    {
        protected int level;
        protected int points;

        public Score(int level, int points)
        {
            this.level = level;
            this.points = points;
        }

        //this method is virtual for later override in other class
        public virtual int ComputeValue()
        {
            return level * points;
        }

        public override string ToString()
        {
            return $"Score of level {level}: value = {ComputeValue()}, points: {points}";
        }
    }
}
