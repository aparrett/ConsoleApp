using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Name = "Anthony";
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}
