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
                case "SweepskatesStackManager":
                    return new SweepskatesStackManager();
                case "sweepskatesStackManager":
                    return new SweepskatesQueueManager();
                
            }
        }
    }
}

