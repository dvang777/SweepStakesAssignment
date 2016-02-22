using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> T;
        string ContestName;

        public Sweepstakes(string contestName)
        {
            ContestName = contestName;
        }

        public void RegisterContestant(Contestant contestant)
        {

                T.Add(T.Count, contestant);
        }

        public string PickWinner()
        {
            Random rand = new Random();
            int randNum = rand.Next(T.Count);
            Contestant winner = T[randNum];
            return winner.firstName + " " + winner.lastName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(T.ToString());
        }

    }
}
