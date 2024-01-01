using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroceriesApi.Core.DataAccess.ModelBUilderExtensions;

public static class GroceryListModelBuilderExtensions
{
    public static void RegisterGroceryListEntity(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DbGroceryList>(
            entity =>
            {
                entity.ToTable("GroceryLists");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).HasMaxLength(50);
            });
    }

}
