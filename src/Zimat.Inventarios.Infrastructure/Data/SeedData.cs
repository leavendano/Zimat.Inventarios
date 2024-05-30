using Zimat.Inventarios.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Zimat.Inventarios.Infrastructure.Data;

public static class SeedData
{
  public static readonly Contributor Contributor1 = new("Luis");
  public static readonly Contributor Contributor2 = new("Ana");

  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var dbContext = new AppDbContext(
        serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
    {
      if (dbContext.Contributors.Any()) return;   // DB has been seeded

      PopulateTestData(dbContext);
    }
  }
  public static void PopulateTestData(AppDbContext dbContext)
  {
    foreach (var contributor in dbContext.Contributors)
    {
      dbContext.Remove(contributor);
    }
    dbContext.SaveChanges();
    Contributor1.SetPhoneNumber("9621712808");
    
    Contributor2.SetPhoneNumber("9621489749");
    
    dbContext.Contributors.Add(Contributor1);
    dbContext.Contributors.Add(Contributor2);

    dbContext.SaveChanges();
  }
}
