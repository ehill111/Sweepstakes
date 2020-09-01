using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{   
    class Sweepstakes
    {   //Member variables have/has a/an...
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        
        //int companySelection;
        //int contestantSelection;
        int winningTicket;

        //Properties

        //Constructor
        public Sweepstakes(string name)
        {
            Dictionary<int, Contestant> contestant = new Dictionary<int, Contestant>(); 
        }
        //Methods do something.
        public void RegisterContestant(Contestant contest)
        {
            //Add registrant to contestant list.
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            contestants.Add(Userinterface.RequestContestantContactData);//need help
        }
        public void PickWinner()
        {
            //int companySelection = 053221;
            //if(contestantSelection == companySelection)
            //{
            //    Console.WriteLine("Congratulations! You win one million dollars!");
            //}
            //else if(contestantSelection != companySelection)
            //{
            //    Console.WriteLine("Oh, shucks! Your number didn't win this time.");
            //}

            //switch (053221)
            //{
            //    case 094420:
            //        break;
            //    case 883099:
            //        break;
            //    case 053221:
            //        Console.WriteLine("Congratulation!" + 053221 + "is the winning ticket! You win one million dollars!");
            //        break;
            //    case 222209:
            //        break;
            //    case 737389:
            //}
           
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            contestants.Add(053221, "Eric");
            contestants.Add(934096, "Sonny");
            contestants.Add(883940, "Alexis");

            Console.WriteLine("Enter the winning ticket number: ");
            int winningTicket = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, string> contestant in contestants)
            {
                if (contestant.Key  == winningTicket)
                Console.WriteLine({contestant.Value} " has the winning ticket!");
            }


        } 
        public void PrintContestantInfo(Contestant contestant)
        {
            //Get ContestantInfo from database.
            Console.WriteLine("");
        }


    }
}
