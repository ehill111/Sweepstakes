﻿using System;
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
        string contestantFName;
        string contestantLName;
        string contestantEMail;
        string nameOfSweepstakes;
        int registrationNumber;

        //Methods do something.
        public static void RequestContestantContactData(string contestantFirstName, string contestantLastName, string contestantEmail, string sweepstakesName, int contestantRegistrationNumber)
        {
            Console.WriteLine("Please enter your first name and press Enter.");
            string contestantFName = Console.ReadLine();
            
            Console.WriteLine("Please enter your last name and press Enter.");
            string contestantLName = Console.ReadLine();

            Console.WriteLine("Please enter your email address and press Enter.");
            string contestantEMail = Console.ReadLine();

            Console.WriteLine("Please enter the name of the sweepstakes you are entering and press Enter.");
            string nameOfSweepstakes = Console.ReadLine();

            Console.WriteLine("Please enter your sweepstakes registration number and press Enter.");
            int registrationNumber = int.Parse(Console.ReadLine());
        }







    }
}
