﻿using System;
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
        

        //Properties

        //Constructor
        public Sweepstakes(string name)
        {
            
        }
        //Methods do something.
        public void RegisterContestant(Contestant contest)
        {
            //Add registrant to contestant list.
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            //contestants.Add(Userinterface.RequestContestantContactData);
        }
        public void PickWinner()
        {

        } 

        public void PrintContestantInfo(Contestant contestant)
        {

        }


    }
}
