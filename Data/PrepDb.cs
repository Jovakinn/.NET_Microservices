using PlatformService.Model;

namespace PlatformService.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
    }

    private static void SeedData(AppDbContext? context)
    {
        if (!context.Platforms.Any())
        {
            Console.WriteLine("--> Seeding Data...");
            
            context.Platforms.AddRange(
                new Platform
                {
                    Name = "Max",
                    Publisher = "Microsoft",
                    Cost = "Full Free"
                },
                new Platform
                {
                    Name = "Jeff",
                    Publisher = "Apple",
                    Cost = "100$"
                },
                new Platform
                {
                    Name = "Max",
                    Publisher = "Microsoft",
                    Cost = "Full Free" 
                });
            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}