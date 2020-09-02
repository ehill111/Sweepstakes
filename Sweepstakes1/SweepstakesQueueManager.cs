using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{       
    
    class SweepstakesQueueManager : ISweepstakesManager 
    {   //Member variables have/has a/an...
        private Queue<Sweepstakes> queue;

        //Methods do something.
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue<string> Sweepstake = new Queue<string>();

            Sweepstake.Enqueue("Diamond");
            Sweepstake.Enqueue("Ruby");
            Sweepstake.Enqueue("Emerald");
            Sweepstake.Enqueue("Gold");
            Sweepstake.Enqueue("Silver");

            Console.WriteLine("Sweepstakes in queue: ");
            foreach (string name in Sweepstake)
            {
                Console.WriteLine(Sweepstake);
            }
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
