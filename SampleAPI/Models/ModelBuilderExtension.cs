using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category 
                {   Id =1, 
                    Name = "Active", 
                    
                }
                )

            modelBuilder.Entity<Product>().HasData(
                new Product
                { Id = 1,
                    CategoryId = 1,
                    Sku = "SVA",
                    Name = "Name",
                    Description = "",
                    Price = 10,
                    IsAvailable = true
                }
    }
}
