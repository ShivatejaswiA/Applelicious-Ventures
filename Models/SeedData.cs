using Applelicious_Ventures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;


namespace Applelicious_Ventures.Models;

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Applelicious_VenturesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Applelicious_VenturesContext>>()))
            {
                // Look for any movies.
               if (context.Apple.Any())
               {
                    return;   // DB has been seeded
                }
            context.Apple.AddRange(
                new Apple
                {
                    Origin = "India",
                    ImportDate = DateTime.Parse("2024-2-12"),
                    Color = "Romantic Comedy",
                    Price = 7.99M,
                   


                },
                new Apple
                {
                    Origin = "India",
                    ImportDate = DateTime.Parse("1989-2-12"),
                    Color = "Romantic Comedy",
                    Price = 7.99M
                },
                new Apple
                {
                    Origin = "India",
                    ImportDate = DateTime.Parse("1989-2-12"),
                    Color = "Romantic Comedy",
                    Price = 7.99M
                },
                new Apple
                {
                    Origin = "India",
                    ImportDate = DateTime.Parse("1989-2-12"),
                    Color = "Romantic Comedy",
                    Price = 7.99M
                }
            );
                context.SaveChanges();
            }
        }
    }
