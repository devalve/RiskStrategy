using Microsoft.AspNetCore.Mvc;
using RiskStrategy.Models;

namespace RiskStrategy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyController : ControllerBase
{
    private readonly AppDbContext _context;

    public CompanyController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Company> Get()
    {
        return _context.Companies.ToList();
    }
}