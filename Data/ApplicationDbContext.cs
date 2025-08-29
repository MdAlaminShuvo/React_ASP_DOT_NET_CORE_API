using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedMango_API.Models;

namespace RedMango_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
        
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Spring Roll",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/spring%20roll.jpg",
                    Price = 7.99,
                    Category = "Appetizer",
                    SpecialTag = ""
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "Idli",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/idli.jpg",
                    Price = 8.99,
                    Category = "Appetizer",
                    SpecialTag = "Best Seller"
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Panu Puri",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/pani%puri.jpg",
                    Price = 8.99,
                    Category = "Appetizer",
                    SpecialTag = "Best Seller"
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Hakka Noodles",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/hakka%noodles.jpg",
                    Price = 10.99,
                    Category = "Entree",
                    SpecialTag = ""
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Malai Kofta",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/malai%kofta.jpg",
                    Price = 12.99,
                    Category = "Entree",
                    SpecialTag = "Top Rated"
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Paneer Pizza",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/paneer%pizza.jpg",
                    Price = 11.99,
                    Category = "Entree",
                    SpecialTag = ""
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Paneer Tikka",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/panner%tikka.jpg",
                    Price = 13.99,
                    Category = "Entree",
                    SpecialTag = "Chef's Special"
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "Carrot Love",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/carrot.jpg",
                    Price = 4.99,
                    Category = "Dessert",
                    SpecialTag = "Chef's Special"
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Rasmalai",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/rasmalai.jpg",
                    Price = 4.99,
                    Category = "Dessert",
                    SpecialTag = "Chef's Special"
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Sweet Rolls",
                    Description = "Fusc tincident maximus leo, sed scelerisque massa auctor",
                    Image = "https://dotnetmasteryimages.blob.core.windows.net/redmango/sweet%20roll.jpg",
                    Price = 3.99,
                    Category = "Dessert",
                    SpecialTag = "Top Rated"
                });
        }
    }
}
