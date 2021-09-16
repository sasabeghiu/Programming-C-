using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment3
{
    class Program
    {
        const string StateFilename = "2020-votes.csv";
        const string ElectorsFilename = "2020-electors.csv";
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            List<StateResult> stateResults = ReadStateResults(StateFilename);
            List<StateElectors> stateElectors = ReadStateElectors(ElectorsFilename);
            if ((stateResults.Count) == 0 || (stateElectors.Count == 0))
            {
                Console.WriteLine("nothing read from the file!");
                return;
            }

            DisplayCandidateElectors(GetCandidateElectors(stateResults, stateElectors));
            Console.ReadKey();
        }
        List<StateResult> ReadStateResults(string filename)
        {
            List<StateResult> results = new List<StateResult>();
            if (!File.Exists(filename))
            {
                return results;
            }

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(';');
                StateResult result = new StateResult();
                result.StateName = fields[0];
                result.CandidateName = fields[1];
                result.PartyName = fields[2];
                result.CandidateVotes = int.Parse(fields[3]);
                results.Add(result);
            }
            reader.Close();
            return results;
        }
        List<StateElectors> ReadStateElectors(string filename)
        {
            List<StateElectors> electors = new List<StateElectors>();
            if (!File.Exists(filename))
            {
                return electors;
            }

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(';');
                StateElectors elector = new StateElectors();
                elector.StateName = fields[0];
                elector.ElectorsCount = int.Parse(fields[1]);
                electors.Add(elector);
            }
            reader.Close();
            return electors;
        }
        void DisplayStateResults(List<StateResult> results)
        {
            foreach (StateResult result in results)
            {
                Console.WriteLine($"{result.StateName}: {result.CandidateName} ({result.PartyName}), {result.CandidateVotes} votes");
            }
        }
        string WinnerOfState(List<StateResult> stateResults, string stateName)
        {
            int max = 0;
            string candidate = "";
            foreach (StateResult stateResult in stateResults)
            {
                if (stateResult.StateName != stateName)
                    continue;
                if (stateResult.CandidateVotes > max)
                {
                    max = stateResult.CandidateVotes;
                    candidate = stateResult.CandidateName;
                }
            }
            return candidate;
        }
        Dictionary<string, int> GetCandidateElectors(List<StateResult> stateResults, List<StateElectors> stateElectors)
        {
            Dictionary<string, int> candidates = new Dictionary<string, int>();

            foreach (StateElectors electrors in stateElectors)
            {
                string winner = WinnerOfState(stateResults, electrors.StateName);

                if (candidates.ContainsKey(winner))
                {
                    candidates[winner] += electrors.ElectorsCount;
                }
                else
                {
                    candidates.Add(winner, electrors.ElectorsCount);
                }
            }
            return candidates;
        }
        void DisplayCandidateElectors(Dictionary<string, int> candidateElectors)
        {
            foreach (KeyValuePair<string, int> candidate in candidateElectors)
            {

                Console.WriteLine($"{candidate.Key} => {candidate.Value} electors");
            }
        }
    }
}
