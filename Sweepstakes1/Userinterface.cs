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
        public static void RequestContestantContactData(string firstName, string lastName, string email, int registrationNumber)
        {
            Console.WriteLine("Please enter your first name and press Enter.");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter your last name and press Enter.");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter your email address and press Enter.");
            string Email = Console.ReadLine();

            Console.WriteLine("Please enter your sweepstakes registration number and press Enter.");
            int registNumber = int.Parse(Console.ReadLine());
        }







    }
}
