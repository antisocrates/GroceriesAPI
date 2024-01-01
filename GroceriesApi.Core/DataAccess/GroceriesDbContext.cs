using GroceriesApi.Core.DataAccess.ModelBUilderExtensions;
using Microsoft.EntityFrameworkCore;

namespace GroceriesApi.Core.DataAccess;

public class GroceriesDbContext : DbContext
{
    public GroceriesDbContext(DbContextOptions<GroceriesDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.RegisterGroceryListEntity();
    }

}
