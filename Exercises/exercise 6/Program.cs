using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var names = Console.ReadLine();
            Reversed(names);
           
        }
        static void Reversed(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
