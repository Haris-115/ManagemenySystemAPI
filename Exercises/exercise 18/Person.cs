using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_18
{
    class Person
    {
        public string firstName;
        public string lastName;
        public void introduce()
        {
            Console.WriteLine("First Name : " + firstName + " " + "Last Name : " + lastName);
            Console.WriteLine("Full Name: {0} {1}", firstName, lastName);
        }
    }
}