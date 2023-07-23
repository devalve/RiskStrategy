using Microsoft.AspNetCore.Mvc;
using RiskStrategy.Models;
using System.Diagnostics;

namespace RiskStrategy.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        CompanyModelDataSeeder.SeedData(_context);
        var model = _context.Companies.ToList();
        return View(model);
    }

    public IActionResult Details(int id)
    {
        var model = _context.Companies.FirstOrDefault(o => o.Id == id);
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}