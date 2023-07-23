namespace RiskStrategy.Models;

public class Company
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Employees { get; set; }
}
