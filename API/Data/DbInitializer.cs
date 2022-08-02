using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            if (context.Customers.Any()) return;
            var customers = new List<Customer>
            {
                new Customer
                {
                  CustomerCode="C001",
                  CustomerName="Vaibhavi Enterprises",
                  Address="Pune",
                  State="Maharashtra",
                  City="Pune",
                  PhoneNo="0123",
                  Email="abcd@gmail.com",
                  PANNO="ASAPG07521",
                  GSTINNo="27ASAPG075211Z7"
                },
                new Customer
                {
                  CustomerCode="C002",
                  CustomerName="Amol Enterprises",
                  Address="Pune",
                  State="Maharashtra",
                  City="Pune",
                  PhoneNo="0123",
                  Email="abcd@gmail.com",
                  PANNO="ASAPG07521",
                  GSTINNo="27ASAPG075211Z7"
                },
                new Customer
                {
                  CustomerCode="C003",
                  CustomerName="Aastha Enterprises",
                  Address="Pune",
                  State="Maharashtra",
                  City="Pune",
                  PhoneNo="0123",
                  Email="abcd@gmail.com",
                  PANNO="ASAPG07521",
                  GSTINNo="27ASAPG075211Z7"
                },
                new Customer
                {
                  CustomerCode="C004",
                  CustomerName="Gaurav Enterprises",
                  Address="Pune",
                  State="Maharashtra",
                  City="Pune",
                  PhoneNo="0123",
                  Email="abcd@gmail.com",
                  PANNO="ASAPG07521",
                  GSTINNo="27ASAPG075211Z7"
                },
                new Customer
                {
                  CustomerCode="C005",
                  CustomerName="Balaji Enterprises",
                  Address="Pune",
                  State="Maharashtra",
                  City="Pune",
                  PhoneNo="0123",
                  Email="abcd@gmail.com",
                  PANNO="ASAPG07521",
                  GSTINNo="27ASAPG075211Z7"
                },
            };
            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
            }

            context.SaveChanges();


        }
    }
}