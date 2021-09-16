using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    public class BonusScore : Score
    {
        //extra field
        public int bonus;

        public BonusScore(int level, int points, int bonus)
            : base(level, points)//clever use of the fact that bonusscore derives from score
        {
            this.bonus = bonus;
        }

        public override int ComputeValue()
        {
            return base.ComputeValue() + (10 * bonus);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, bonus: {bonus} ";
        }
    }
}
