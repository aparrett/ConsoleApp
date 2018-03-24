using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Promote()
        {
            // ..
        }
    }
}