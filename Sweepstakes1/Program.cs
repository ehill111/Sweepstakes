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

            Console.WriteLine("Hello world!");
            Console.ReadLine();
                       
        }
    }
}
