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
        int winningTicket;

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
