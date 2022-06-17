using System;

namespace exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var numbers = Convert.ToInt32(Console.ReadLine());
            Factorial(numbers);
        }
        static void Factorial(int number)
        {
            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
