using System;
using System.Collections.Generic;

namespace Programming3_assignments
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
            Assignment5();
            //Assignment6();
        }

        void Assignment1()
        {
            Score score = new Score(6, 500);
            Console.WriteLine(score);
        }

        void Assignment2()
        {
            Score score1 = new Score(3, 600);
            BonusScore score2 = new BonusScore(7, 500, 8);
            Score score3 = new Score(6, 750);
            BonusScore score4 = new BonusScore(4, 240, 6);

            List<Score> scoreList = new List<Score>();
            scoreList.Add(score1);
            scoreList.Add(score2);
            scoreList.Add(score3);
            scoreList.Add(score4);

            foreach (Score score in scoreList)
            {
                Console.WriteLine(score);
            }
        }

        void Assignment3()
        {
            Score score1 = new Score(1, 20);
            Score score2 = new Score(2, 40);
            BonusScore score3 = new BonusScore(3, 50, 9);

            GameScore gameScore = new GameScore("Test", new DateTime(06 / 04 / 2021));
            gameScore.Scores.Add(score1);
            gameScore.Scores.Add(score2);
            gameScore.Scores.Add(score3);

            foreach (Score score in gameScore.Scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine($"GameScore value: {gameScore.Value}");
        }

        void Assignment5()
        {
            Bag bagObject = new Bag(500);
            bagObject.Add(new Gem(100, 10));
            bagObject.Add(new Gem(200, 20));
            bagObject.Add(new Weapon(100, WeaponType.Sword));
            Console.WriteLine($"Total Weight: {bagObject.CalculateWeight()}");
        }

        void Assignment6()
        {
            //dictionary???
        }

    }
}
