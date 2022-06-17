using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            check(number);
        }
        static void check(int number1)
        {
            if (number1 >= 1 && number1 <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
