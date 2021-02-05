using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            {
                customer.Id = 0001;
                customer.Name = "Bob";
                customer.LastName = "A.";
                customer.PhoneNumber = "+90 652 987 35 62";
                customer.Email = "bob.a@mail.com";
            }
            Customer customer1 = new Customer();
            {
                customer1.Id = 0002;
                customer1.Name = "Maria";
                customer1.LastName = "B.";
                customer1.PhoneNumber = "+90 695 574 12 32";
                customer1.Email = "maria.b@mail.com";

            }
            Customer customer2 = new Customer();
            {
                customer2.Id = 0003;
                customer2.Name = "Robert";
                customer2.LastName = "P.";
                customer2.PhoneNumber = "988 999 65 99";
                customer2.Email = "robert.p@mail.com";
            }
            List<Customer> customers = new List<Customer> { customer, customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("------ Welcome to system ------");
            Console.WriteLine("------ Please press to 'Enter' ------");
            Console.WriteLine("------ Please keep pressing 'Enter' after each action takes place. ------");
            Console.ReadKey();
            Console.WriteLine("------ Customer Creation ------");
            customerManager.Add(customer);
            Console.WriteLine("------ Customer Remove ------");
            customerManager.Remove(customer1);
            Console.WriteLine("------ Customer List ------");
            customerManager.CustomerList(customers);
        }

    }
}

