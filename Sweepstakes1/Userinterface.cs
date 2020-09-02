using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{   //Static can't instantiate.
    //May only have input parameters...no get or set of fields of an instance.
    //Think output instead of objects performing actions.
    public class Userinterface
    {   //Member variables have/has a/an...
       
        //Methods do something.
        public static void RequestContestantContactData()
        {
            Console.WriteLine("Please enter your first name and press Enter.");
            string contestantFirstName = Console.ReadLine();
            
            Console.WriteLine("Please enter your last name and press Enter.");
            string contestantLName = Console.ReadLine();

            Console.WriteLine("Please enter your email address and press Enter.");
            string contestantEMail = Console.ReadLine();
        }
        public static string GetUserInfo(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine();
            return input;
        }
        public static string ChooseSweepstakesManager()
        {
            Console.WriteLine("Please select the sweepstakes manager you would like to use. Your choices are (1) SweepstakesStackManager or (2) SweepstakesQueueManager. Type (1) or (2) and press Enter.");
            string input = Console.ReadLine();
            return input;
            
        }







    }
}
