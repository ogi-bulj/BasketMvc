using BasketMvc.Data;
using BasketMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BasketMvcContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BasketMvcContext>>()))
        {
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    Naziv = "Beefsteak",
                    Kategorija = "Meat",
                    Cijena = 80
                },
                new Product
                {
                    Naziv = "Tuna",
                    Kategorija = "Fish",
                    Cijena = 75
                },
                new Product
                {
                    Naziv = "Banana",
                    Kategorija = "Fruits",
                    Cijena = 5
                },
                new Product
                {
                    Naziv = "Tomato",
                    Kategorija = "Vegetables",
                    Cijena = 2
                }
            );
            context.SaveChanges();
        }
    }
}