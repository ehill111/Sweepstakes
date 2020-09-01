using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{
    public class MarketingFirm
    {    //Member variables have/has a/an...
        //private ISweepStakesManager _manager;

        //Constructor(s) create mold for..
        //public MarketingFirm(ISweepstakesManager manager)
        //    {

        //    }        
           
        //Methods do something.
        public void CreateSweepstakes()
        {
            Sweepstakes newSweepstake = new Sweepstakes("Big summer blowout");
            Contestant contestant = new Contestant("Bob");
            contestant.FirstName = Userinterface.GetUserInfo("Enter the first name");
            contestant.LastName = Userinterface.GetUserInfo("Enter the last name");
            contestant.EmailAddress = Userinterface.GetUserInfo("Enter your email");
            contestant.RegistrationNumber = 1;
            newSweepstake.RegisterContestant(contestant);
        }

    }

}
   

    
   

