﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes1
{   //Member variables have/has a/an...
    //Properties
    //Constructor(s) create mold for...
    //Methods do something.
    class SweepstakesStackManager : ISweepstakesManager 
    {
        //Member variables have/has a/an...
        private Stack<Sweepstakes> stack;


        //Constructor makes mold.
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        //Methods do something.
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {//LIFO
            stack.Push(sweepstakes);


            //Stack<string> sweepstakeName = new Stack<string>();
            
            //sweepstakeName.Push("Diamond");
            //sweepstakeName.Push("Emerald");
            //sweepstakeName.Push("Ruby");
            //sweepstakeName.Push("Gold");
            //sweepstakeName.Push("Silver");

            //Console.WriteLine("Names of sweepstakes we manage: ");
            //foreach (string name in sweepstakeName)
            //{
            //    Console.WriteLine(name); 
            //}

        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
            //Stack<string> sweepstakeName = new Stack<string>();

            //sweepstakeName.Push("Diamond");
            //sweepstakeName.Push("Emerald");
            //sweepstakeName.Push("Ruby");
            //sweepstakeName.Push("Gold");
            //sweepstakeName.Push("Silver");

            
            //Console.WriteLine(sweepstakeName.);
           
            //{
            //    Console.WriteLine(name);
            //}
        }








    }
}
