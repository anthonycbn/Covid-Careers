using System;
using System.Collections.Generic;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer chike = new Customer()
            {
                ID = 046,
                Name = "Chike Anichukwu",
                Receivable = 4500,
            };
            Customer Izu = new Customer()
            {
                ID = 047,
                Name = "Izu Francis",
                Receivable = 7500,
            };
            Customer Ben = new Customer()
            {
                ID = 048,
                Name = "Benignus Nnamdi",
                Receivable = 7500,
            };
            Customer Jess = new Customer()
            {
                ID = 049,
                Name = "Jessica Francis",
                Receivable = 7500,
            };
            List<Customer> customers = new List<Customer>();
            customers.Add(chike);
            customers.Add(Izu);
            customers.Add(Jess);
            customers.Add(Ben);
            foreach (Customer c in customers)
            {
                Console.WriteLine("The name of the customer is {0}, and the customer ID is {1}, he is owing the Bank a total of {2} naira and the money is payable on or before 12/04/2020\n", c.Name, c.ID, c.Receivable);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Receivable { get; set; }
    }
}