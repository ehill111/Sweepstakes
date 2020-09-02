using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Userinterface.RequestContestantContactData();
            ////Contestant bob = new Contestant();
            //bob.FirstName = Userinterface.GetUserInfo("Please enter your first name");
            //bob.LastName = Userinterface.GetUserInfo("Please enter the last name");
            Console.WriteLine("Please select the sweepstakes manager you would like to use. Your choices are (1) SweepstakesStackManager or (2) SweepstakesQueueManager. Type (1) or (2) and press Enter.");
            int input = int.Parse(Console.ReadLine());
            //return input;
            Console.WriteLine("Hello world!");
            Console.ReadLine();
                       
        }
    }
}
