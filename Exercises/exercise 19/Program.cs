using System;

namespace exercise_19
{

    public class Person
    {
        public string Name;
        public void Introduce(string to) 
        {
            Console.WriteLine("Hi, {0} My name is {1}", to, Name);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Haris";
            person.Introduce("Aqdas");
        }
    }
}
