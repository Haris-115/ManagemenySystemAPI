using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_32
{
    public class Vehicle
    {
        private readonly string _registerationNumber;
        public Vehicle(string registerationNumber) 
        {
            _registerationNumber = registerationNumber;
            Console.WriteLine("Vehicle has been initialised." + registerationNumber);
        }
    }
}
