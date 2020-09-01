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
        int companySelection;
        int contestantSelection;
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
            //Console.WriteLine("Select a number from 1 to 1,000,000 and press enter. If you select the same number that will be chosen on New Year's Eve, you win $1,000,000. Type in your number and press Enter.");
            //int contestantSelection = int.Parse(Console.ReadLine());
            //Console.ReadLine([contestantSelection]);
            //Random rng = new Random();
            //companySelection = rng.Next(1, 1000001);
            //Sweepstakes winningTicket = new Sweepstakes();

            //int companySelection = 053221;
            //if(contestantSelection == companySelection)
            //{
            //    Console.WriteLine("Congratulations! You win one million dollars!");
            //}
            //else if(contestantSelection != companySelection)
            //{
            //    Console.WriteLine("Oh, shucks! Your number didn't win this time.");
            //}

            switch (053221)
            {
                case 094420:
                    break;
                case 883099:
                    break;
                case 053221:
                    Console.WriteLine("Congratulation!" + 053221 + "is the winning ticket! You win one million dollars!");
                    break;
                case 222209:
                    break;
                case 737389:
            }
            

                     
                    
        } 

        public void PrintContestantInfo(Contestant contestant)
        {

        }


    }
}
