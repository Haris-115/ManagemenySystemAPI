using System;
using System.Collections.Generic;

namespace exercise_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"haris");
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.name);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
