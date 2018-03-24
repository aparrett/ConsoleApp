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
            var customer = new Customer(5, "Anthony");
            var order = new Order();

            customer.Orders.Add(order);
            Console.WriteLine(customer.Name);

            var customer1 = new Customer(4, "Meagan");
            Console.WriteLine(customer1.Name);
        }
    }
}
