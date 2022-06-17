using System;

namespace exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Add()
            {
                var a=10;
                Console.WriteLine(a);
            }
            Add();
            var Haris = new Person();
            Console.WriteLine("Enter your first name: ");
            Haris.firstName = Console.ReadLine();
            Haris.firstName = Haris.firstName.ToUpper();
            Haris.lastName = "Malik";
            Haris.lastName = Haris.lastName.ToUpper();
            Haris.introduce();
            var Zohaib = new Class1();
            Zohaib.myName = "Zohaib Sajjad";
            var splittedName = Zohaib.myName.Split();
            foreach(var n in splittedName)
            {
                Console.WriteLine(n);
            }
            Zohaib.Show();
        }
    }
}

