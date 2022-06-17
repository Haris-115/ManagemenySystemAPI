using System;

namespace stack_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new ss();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}

