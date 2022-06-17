using System;

namespace exercise_29
{
    public class Person
    {
        private int id { get; set; }
        public int setget
        {
            set
            {
                int id = 1;
            }
            get
            {
                int id = 1;
                return id;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.setget);
        }
    }
}
