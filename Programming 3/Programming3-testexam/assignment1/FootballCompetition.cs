using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class FootballCompetition
    {
        public List<FootballTeam> teams;
        public List<FootballMatch> matches;
        public Dictionary<FootballMatch, FootballMatchResult> matchResult;

        public FootballCompetition()
        {
            teams = new List<FootballTeam>();
            matches = new List<FootballMatch>();
            matchResult = new Dictionary<FootballMatch, FootballMatchResult>();
        }

        public void GenerateMatches()
        {
            foreach (FootballTeam team1 in teams)
            {
                foreach (FootballTeam team2 in teams)
                {
                    if (team1 != team2)
                    {
                        FootballMatch match = new CompetitionMatch(team1, team2, 1);
                        this.matches.Add(match);
                    }
                }
            }
        }

        public void CalculateTeamPoints()
        {
            foreach (FootballTeam team in teams)
                team.TotalPoints = 0;

            foreach(KeyValuePair<FootballMatch, FootballMatchResult> item in matchResult)
            {
                item.Key.homeTeam.TotalPoints += item.Value.HomeTeamPoints;
                item.Key.awayTeam.TotalPoints += item.Value.AwayTeamPoints;
            }
        }
    }
}
