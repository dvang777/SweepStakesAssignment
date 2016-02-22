using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class Contestant
    {
        //public int contestantNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        //public int age { get; set; }

        public Contestant(string firstName, string lastname)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}
