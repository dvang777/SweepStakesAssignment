using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant("", "");
            Dictionary<string, string> contestanDictionary = new Dictionary<string, string>();
            contestanDictionary.Add("David", "Anderson");
            contestanDictionary.Add("Mitch", "Richmond");
            contestanDictionary.Add("Tony", "Douglas");
            contestanDictionary.Add("Mark", "Ripon");
            contestanDictionary.Add("Sebastian", "Stan");


            Sweepstakes sweepstakes = new Sweepstakes("Million Dollar Sweepstakes");
            sweepstakes.RegisterContestant(new Contestant("David", "Anderson"));
            sweepstakes.RegisterContestant(new Contestant("Mitch", "Richmond"));
            sweepstakes.RegisterContestant(new Contestant("Tony", "Douglas"));
            sweepstakes.RegisterContestant(new Contestant("Mark", "Ripon"));
            sweepstakes.RegisterContestant(new Contestant("Sebastion", "Stan"));


            string winningContestant = sweepstakes.PickWinner();
            Console.WriteLine(winningContestant);
            Console.ReadLine();
        }
    }
}
