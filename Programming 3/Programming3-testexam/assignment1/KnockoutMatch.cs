using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public enum KnockoutType { QuarterFinal, SemiFinal, Final };
    class KnockoutMatch : ChampionshipMatch
    {
        public KnockoutType type;

        public KnockoutMatch(FootballTeam homeTeam, FootballTeam awayTeam, KnockoutType type)
            : base(homeTeam, awayTeam)
        {
            this.type = type;
        }
    }
}
