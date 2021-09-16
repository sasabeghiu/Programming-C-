using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class FootballMatchResult
    {
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }

        public FootballMatchResult(int homeGoals, int awayGoals)
        {
            this.HomeTeamGoals = homeGoals;
            this.AwayTeamGoals = awayGoals;
        }

        public int HomeTeamPoints
        {
            get
            {
                return CalculatePoints(HomeTeamGoals, AwayTeamGoals);
            }
        }

        public int AwayTeamPoints
        {
            get
            {
                return CalculatePoints(AwayTeamGoals, HomeTeamGoals);
            }
        }

        private int CalculatePoints(int homeGoals, int awayGoals)
        {
            if (homeGoals == awayGoals)
                return 1;
            else if (homeGoals > awayGoals)
                return 3;
            else
                return 0;
        }
    }
}
