using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetMvcEntityDemo.Models;

namespace AspNetMvcEntityDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        using NorthwindContext context = new();
        List<Customer> allCustomers = [.. context.Customers];

        return View(allCustomers);
    }

    [HttpPost]
    public IActionResult Index(IFormCollection form)
    {
        string? companyName = form["companySearch"];
        string? countryName = form["countrySearch"];

        Console.WriteLine($"Search criteria: company=\"{companyName}\", country=\"{countryName}\"");

        using NorthwindContext context = new();
        var query = context.Customers.AsQueryable();

        if (!string.IsNullOrEmpty(companyName))
        {
            query = query.Where(c => c.CompanyName.Contains(companyName));
        }

        if (!string.IsNullOrEmpty(countryName))
        {
            query = query.Where(c => c.Country == countryName);
        }

        List<Customer> matchingCustomers = [.. query];
        Console.WriteLine($"Found {matchingCustomers.Count} customer(s).");

        return View(matchingCustomers);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
