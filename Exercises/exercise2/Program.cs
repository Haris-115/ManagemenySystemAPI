using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            Max(number1,number2);
        }
        static void Max(int a,int b)
        {
            var max = (a > b) ? a : b;
            Console.WriteLine("Max is " + max);
        }
    }
}
