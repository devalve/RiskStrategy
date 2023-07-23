namespace RiskStrategy.Models;

public static class CompanyModelDataSeeder
{
    public static void SeedData(AppDbContext context)
    {
        if (context.Companies.Any())
        {
            return;
        }

        context.Companies.AddRange(
            new Company
            {
                CompanyName = "Company A",
                Address = "123 Main St.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Employees = 10
            },
            new Company
            {
                CompanyName = "Company B",
                Address = "456 Oak St.",
                Description = "Praesent sagittis tristique quam, sed euismod elit placerat ut.",
                Employees = 20
            },
            new Company
            {
                CompanyName = "Company C",
                Address = "789 Maple St.",
                Description = "Maecenas vestibulum nulla elit, ut maximus sapien bibendum et.",
                Employees = 30
            }
        );

        context.SaveChanges();
    }
}