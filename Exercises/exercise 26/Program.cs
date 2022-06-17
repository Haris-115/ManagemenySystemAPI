using System;

namespace exercise_26
{
    public class Person
    {
        private int id;
        public void SetName()
        {
            Console.WriteLine("Enter Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            
        }
        public void GetName()
        {
            Console.WriteLine(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetName();
            person.GetName();
        }
    }
}
