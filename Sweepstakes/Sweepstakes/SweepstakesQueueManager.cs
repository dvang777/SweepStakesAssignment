using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
             Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
       public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepstakesQueue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
