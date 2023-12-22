using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car() 
        { 
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("This Car is in drive.");
        }

        public bool HasTrunk { get; set; } = true;
    }
}
