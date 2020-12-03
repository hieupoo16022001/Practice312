using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Praticenet.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Nguyen Trung Hieu",
                        Luong = 1000 ,
                        Category = "Boss"
                    },
                  
                    new Product
                    {
                        Name = "Trieu Cao Chinh",
                        Luong = 100,
                        Category = "Security"
                    },
                     new Product
                     {
                         Name = "Nguyen Van Hoang",
                         Luong = 100,
                         Category = "Security"
                     },
                      new Product
                      {
                          Name = "Vu Dinh Hieu",
                          Luong = 100,
                          Category = "Security"
                      }
                     
                );
                context.SaveChanges();
            }
        }
    }
}
