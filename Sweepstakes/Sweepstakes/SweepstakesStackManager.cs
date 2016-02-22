using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakeStack = new Stack<Sweepstakes>();

        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepstakeStack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakeStack.Push(sweepstakes);
        }
    }
}
