using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_20
{
    public class Customer
    {
        public string name;
        public Customer()
        {
            //Console.WriteLine("This is my default constructor");
            this.name = "zohaib";
            //Console.WriteLine(name);
        }
        public Customer(int id) : this()
        {
            Console.WriteLine("This is my constructor with parameter id");
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
        public Customer(int id, string field): this(1)
        {
            //Console.WriteLine("This is my constructor with parameter id and field");
            //Console.WriteLine(field);
            //Console.WriteLine(id);
            //Console.WriteLine(name);
        }
    }
}
