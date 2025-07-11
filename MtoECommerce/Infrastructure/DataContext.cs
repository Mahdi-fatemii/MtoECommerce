using Microsoft.EntityFrameworkCore;
using MtoECommerce.Controllers;

namespace MtoECommerce.Infrastructure
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Shirts", Slug = "shirts" },
                    new Category { Id = 2, Name = "Dress", Slug = "dress" }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Polo Shirt",
                        Slug = "polo-shirt",
                        Description = "A Nice Blue Polo Shirt for Men",
                        Price = 22.79M,
                        CategoryId = 1,
                        Image = "PoloShirt.jpeg"
                    },

                    new Product
                    {
                        Id = 2,
                        Name = "Parina Black Dress",
                        Slug = "parina-black-dress",
                        Description = "Black Strappy Volume-Hem Midi Dress",
                        Price = 127.99M,
                        CategoryId = 2,
                        Image = "BlackDress1.jpeg"
                    },

                    new Product
                    {
                        Id = 3,
                        Name = "Beth Lemon Dress",
                        Slug = "beth-lemon-dress",
                        Description = "Lemon Asymmetric Neckline High-Split Maxi Dress",
                        Price = 132.69M,
                        CategoryId = 2,
                        Image = "LemonDress1.jpeg"
                    },

                    new Product
                    {
                        Id = 4,
                        Name = "Navy & White Stripe Shirt",
                        Slug = "stripe-shirt",
                        Description = "Navy & White Stripe Pure Linen Slim Shirt – Button Down Collar",
                        Price = 75.32M,
                        CategoryId = 1,
                        Image = "StripyShirt1.jpeg"
                    },
                    
                    new Product
                    {
                        Id = 5,
                        Name = "Parina Pink Dress",
                        Slug = "parina-pink-dress",
                        Description = "Pink Strappy Volume-Hem Midi Dress",
                        Price = 110.89M,
                        CategoryId = 2,
                        Image = "PinkDress1.jpeg"
                    },
                    
                    
                    new Product
                    {
                        Id = 6,
                        Name = "Burgundy Sateen Shirt",
                        Slug = "burgundy-sateen-shirt",
                        Description = "Crafted from 100% cotton sateen and cut for a tailored fit. With a classic cutaway collar, mitred cuffs, and a slight sheen from the lustrous fabric, these are the ultimate statement shirts. This shirt features accents of our Name Of The Rose Print.",
                        Price = 106.14M,
                        CategoryId = 1,
                        Image = "RedShirt1.jpeg"
                    }
                );

            modelBuilder.Entity<Page>().HasData(
                new Page { Id = 1, Title = "Home", Slug = "home", Body = "This is the home page" },
                new Page { Id = 2, Title = "About", Slug = "about", Body = "This is the about page" },
                new Page { Id = 3, Title = "Services", Slug = "services", Body = "This is the services page" },
                new Page { Id = 4, Title = "Contact", Slug = "contact", Body = "This is the contact page" }
                );
        }
    }
}
