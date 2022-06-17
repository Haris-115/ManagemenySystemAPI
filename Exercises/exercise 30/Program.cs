using System;

namespace exercise_30
{
    public class Person
    {
        public int id;
        public string name;

        public void Show()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
        }
    }
    public class Me : Person
    {
        public string field;
        public void Display()
        {
            Console.WriteLine("Field is : " + field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var haris = new Me();
            haris.id = 1;
            haris.name = "haris";
            haris.field = "CS";
            haris.Show();
            haris.Display();
        }
    }
}
