using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{
    public class MarketingFirm
    {    //Member variables have/has a/an...
        private ISweepstakesManager _manager;

        //Constructor(s) create mold for..
        //Dependency injection used by giving MarketingFirm inheritance of interface ISweeptakesManager.
        //This allows MarketingFirm class to use either SweepstakesStackManager class or SweepstakesQueueManager class.
        //This is because both classes also inherit from ISweepstakesManager.
        //The use of dependency injection here also decouples MarketingFirm from other classes. Thus making the program easier to maintain.
        MarketingFirm(ISweepstakesManager manager)
            {
            this._manager = manager;
            }        
            //Methods do something.
        public void CreateSweepstakes()
        {
            Sweepstakes newSweepstake = new Sweepstakes("Diamond");
            Contestant contestant = new Contestant("Eric");
            contestant.FirstName = Userinterface.GetUserInfo("Enter the first name");
            contestant.LastName = Userinterface.GetUserInfo("Enter the last name");
            contestant.EmailAddress = Userinterface.GetUserInfo("Enter your email");
            contestant.RegistrationNumber = 1;
            newSweepstake.RegisterContestant(contestant);
        }

    }

}
   

    
   

