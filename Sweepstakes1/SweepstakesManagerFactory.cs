using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{
    public class SweepstakesManagerFactory
    {
        //Methods do something.
        public void ProcessUserSelection()
        {
            switch (Userinterface.ChooseSweepstakesManager())
            {
                case "SweepstakesStackManager":
                    new SweepstakesStackManager();
                    return;
                case "SweepstakesQueueManager":
                    new SweepstakesQueueManager();
                    return;
            }
        }
    }
}

