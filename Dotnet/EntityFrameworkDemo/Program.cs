using EntityFrameworkDemo.Models;

Console.WriteLine("Starting to work with the SQLite Northwind database...");
using NorthwindContext context = new();
var finnishCustomer = context.Customers.Where(
    c => c.Country == "Finland");

foreach (var cust in finnishCustomer)
{
    Console.WriteLine(cust.CompanyName);
}

// context.Dispose();
Console.WriteLine("Database data retrieved.");