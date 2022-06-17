using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_25
{
    class Customer
    {
        public int id;
        public string name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer(int id)
        {
            this.id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            this.name = name;
        }
        public void Promote()
        {
            // a list can not be again initialized because we have used "readdonly" 
            //Orders = new List<Order>();
        }
    }
}
