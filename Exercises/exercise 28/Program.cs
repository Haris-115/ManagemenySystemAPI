using System;

namespace exercise_28
{
    public class Person
    {
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                var age = DateTime.Now - Birthdate;
                var years = age.Days / 365;
                return years;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(2001, 2, 15);
            Console.WriteLine(person.Birthdate);
            Console.WriteLine(person.Age);
        }
    }
}
