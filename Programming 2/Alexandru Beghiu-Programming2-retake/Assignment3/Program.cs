using System;
using System.IO;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        // it doesnt read the file, WHYYYY?
        const string filename = "TK2021-results.csv";
        
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
        }

        void Start()
        {
            List<string> politicalParties = ReadPoliticalParties(filename);
            List<CityResult> cityResults = ReadCityResults(filename, 37);
            List<PoliticalPartyResult> partyResults = GetPartyResults(politicalParties, cityResults);

            if ((politicalParties.Count == 0) || (cityResults.Count == 0))
            {
                Console.WriteLine("No items in the recieved list!"); 
                return;
            }

            Console.WriteLine($"number of political parties: {politicalParties.Count}");
            Console.WriteLine($"number of city results: {cityResults.Count}");

            DisplayPartyResults(partyResults);
            CalculatePartySeats(partyResults);
        }

        List<string> ReadPoliticalParties(string filename)
        {
            List<string> parties = new List<string>();
            if (!File.Exists(filename))
                return parties;

            StreamReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            reader.Close(); //read 1 line

            string[] fields = line.Split(';');

            for (int i = 2; i < fields.Length; i++)
            {
                parties.Add(fields[2]);
            }
            return parties;
        }

        List<CityResult> ReadCityResults(string filename, int nrOfPoliticalParties)
        {
            List<CityResult> results = new List<CityResult>();
            if (!File.Exists(filename))
                return results;

            StreamReader reader = new StreamReader(filename);
            reader.ReadLine();//skip 1 line
            while (!reader.EndOfStream)
            {
                int[] partyVotes = new int[nrOfPoliticalParties];
                string line = reader.ReadLine();
                string[] fields = line.Split(';');

                foreach (CityResult result in results)
                {
                    result.CityName = fields[0];
                    result.TotalVotes = int.Parse(fields[1]);
                    int counter = 0;
                    for (int i = 2; i < fields.Length; i++)
                    {
                        partyVotes[counter] = int.Parse(fields[i]);
                    }
                    result.PartyVotes = partyVotes;
                    results.Add(result);
                }
            }
            reader.Close();
            return results;
        }

        List<PoliticalPartyResult> GetPartyResults(List<string> politicalParties, List<CityResult> cityResults)
        {
            List<PoliticalPartyResult> objects = new List<PoliticalPartyResult>();
            
            foreach (string s in politicalParties)
            {
                PoliticalPartyResult politicalParty = new PoliticalPartyResult();
                objects.Add(politicalParty);
            }
            foreach (CityResult result in cityResults)
            {
                for (int i =0;i<result.PartyVotes.Length;i++)
                {
                    objects[i].TotalVotes += result.PartyVotes[i];
                }
            }
            return objects;
        }

        void DisplayPartyResults(List<PoliticalPartyResult> partyResults)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Results political parties");
            Console.ResetColor();
            foreach (PoliticalPartyResult result in partyResults)
            {
                Console.WriteLine($"{result.Name,-10}: {result.TotalVotes} votes");
            }
        }

        void CalculatePartySeats(List<PoliticalPartyResult> partyResults)
        {

        }
    }
}
