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

            Userinterface.RequestContestantContactData(string firstName, string lastName, string email, int registrationNumber);
            
            Console.WriteLine("Hello world!");
            Console.ReadLine();


            
        }
    }
}
