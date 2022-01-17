using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
          using (var context = new CustomerContext())
            {
                List<Customers> customers = context.Customers.ToList();
                foreach(var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine(customer.Location);
                    Console.WriteLine(customer.Address);
                    Console.WriteLine(customer.PhoneNumber);
                }
            }
        }
    }
}
