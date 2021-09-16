using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class GroupStageMatch : ChampionshipMatch
    {
        public string groupName;
        public GroupStageMatch(FootballTeam homeTeam, FootballTeam awayTeam, string groupName)
            : base(homeTeam, awayTeam)
        {
            this.groupName = groupName;
        }
    }
}
