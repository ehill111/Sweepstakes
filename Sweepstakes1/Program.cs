using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Userinterface.RequestContestantContactData();
            Contestant bob = new Contestant();
            bob.FirstName = Userinterface.GetUserInfo("Please enter your first name");
            bob.LastName = Userinterface.GetUserInfo("Please enter the last name");



            Console.WriteLine("Hello world!");
            Console.ReadLine();
                       
        }
    }
}
