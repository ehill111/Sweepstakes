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
            contestants = new Dictionary<int, Contestant>(); 
        }
        //Methods do something.
        public void RegisterContestant(Contestant contest)
        {
            //Add registrant to contestant list.
            //Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            //I don't need to repeatedly instantiate something.
            contestants.Add(contest.RegistrationNumber, contest);//Study
        }
        public void PickWinner()
        {
            contestants.Add(053221, new Contestant("Eric"));
            contestants.Add(934096, new Contestant("Sonny"));
            contestants.Add(883940, new Contestant("Alexis"));

            Console.WriteLine("Enter the winning ticket number: ");
            int winningTicket = int.Parse(Console.ReadLine());
            //Take the shortest route.
            //foreach (KeyValuePair<int, string> contestant in contestants)
            //{
                //if (contestant.Key  == winningTicket)
                //Console.WriteLine(contestant.Value + " has the winning ticket!");
            //}
        } 
        public void PrintContestantInfo(Contestant contestant)
        {
            //Get ContestantInfo from database.
            //Actually, I can get it more simply.
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }


    }
}
