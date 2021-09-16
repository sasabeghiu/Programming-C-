using System;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            //Assignment1();
            //Assignment2();
            //Assignment3();
            //Assignment5();
            Assignment6();
        }

        void Assignment1()
        {
            FootballPlayer player1 = new FootballPlayer("Peter de Groot", 25);
            Console.WriteLine(player1);
        }

        void Assignment2()
        {
            FootballPlayer player1 = new FootballPlayer("Peter de Groot", 25);
            InternationalPlayer player2 = new InternationalPlayer("Donny van der Beek", 23, 9);
            InternationalPlayer player3 = new InternationalPlayer("Hakim Ziyech", 27, 32);

            List<FootballPlayer> playersList = new List<FootballPlayer>();
            playersList.Add(player1);
            playersList.Add(player2);
            playersList.Add(player3);

            foreach (FootballPlayer player in playersList)
            {
                Console.WriteLine(player);
            }
        }

        void Assignment3()
        {
            FootballPlayer player1 = new FootballPlayer("Peter de Groot", 25);
            InternationalPlayer player2 = new InternationalPlayer("Donny van der Beek", 23, 9);
            InternationalPlayer player3 = new InternationalPlayer("Hakim Ziyech", 27, 32);

            FootballTeam team = new FootballTeam("Ajax");
            team.Players.Add(player1);
            team.Players.Add(player2);
            team.Players.Add(player3);

            Console.WriteLine(team.Name);
            foreach (FootballPlayer player in team.Players)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine($"total transfervaluer: {team.TotalTransferValue}m");
        }

        void Assignment5()
        {
            FootballMatchResult result1 = new FootballMatchResult(2, 1);
            FootballMatchResult result2 = new FootballMatchResult(3, 3);
            FootballMatchResult result3 = new FootballMatchResult(1, 5);

            Console.WriteLine($"football match result: {result1.HomeTeamGoals} - {result1.AwayTeamGoals}");
            Console.WriteLine($"home points: {result1.HomeTeamPoints}");
            Console.WriteLine($"away points: {result1.AwayTeamPoints}");
            Console.WriteLine();
            Console.WriteLine($"football match result: {result2.HomeTeamGoals} - {result2.AwayTeamGoals}");
            Console.WriteLine($"home points: {result2.HomeTeamPoints}");
            Console.WriteLine($"away points: {result2.AwayTeamPoints}");
            Console.WriteLine();
            Console.WriteLine($"football match result: {result3.HomeTeamGoals} - {result3.AwayTeamGoals}");
            Console.WriteLine($"home points: {result3.HomeTeamPoints}");
            Console.WriteLine($"away points: {result3.AwayTeamPoints}");
            Console.WriteLine();
        }

        void Assignment6()
        {
            FootballCompetition competition = new FootballCompetition();
            competition.teams.Add(new FootballTeam("Ajax"));
            competition.teams.Add(new FootballTeam("PSV"));
            competition.teams.Add(new FootballTeam("AZ"));

            competition.GenerateMatches();
        }
    }
}