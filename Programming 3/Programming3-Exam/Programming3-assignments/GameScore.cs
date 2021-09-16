using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    class GameScore
    {
        //readonly property for a list of scores
        public List<Score> Scores { get; private set; }
        //automatic property DateTime
        public DateTime DateTime { get; set; }
        //backing field for property Name
        private string name;
        //read-only property Name
        public string Name
        {
            get
            {
                return name;
            }
        }
        //calculated property that returns a sum of all scores in the list
        public int Value
        {
            get
            {
                int total = 0;
                foreach(Score score in Scores)
                {
                    total += score.ComputeValue();
                }
                return total;
            }
        }
        //ctor that creates the list
        public GameScore(string name, DateTime dateTime)
        {
            this.name = name;
            this.DateTime = dateTime;
            this.Scores = new List<Score>();
        }

    }
}
