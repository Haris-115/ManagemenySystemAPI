using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_32
{
    public class Car : Vehicle
    {
        public Car(string registerationNumber):base(registerationNumber)
        {
            Console.WriteLine("Car has been initialized. "+ registerationNumber);
        }
    }
}
