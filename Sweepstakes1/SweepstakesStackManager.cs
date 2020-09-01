using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{   //Member variables have/has a/an...
    //Properties
    //Constructor(s) create mold for...
    //Methods do something.
    class SweepstakesStackManager
    {
        //Member variables have/has a/an...
        private Stack<Sweepstakes> stack;
        

        //Constructor makes mold.

        //Methods do something.
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {//LIFO
            Stack<string> sweepstakeName = new Stack<string>();
            
            sweepstakeName.Push("Diamond");
            sweepstakeName.Push("Emerald");
            sweepstakeName.Push("Ruby");
            sweepstakeName.Push("Gold");
            sweepstakeName.Push("Silver");

            Console.WriteLine("Names of sweepstakes we manage: ");
            foreach (string name in sweepstakeName)
            {
                 
            }


        }

        public void GetSweepstakes()
        {

        }








    }
}
