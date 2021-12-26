using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web_953503_Alshanikov.Entities;

namespace Web_953503_Alshanikov.Data
{
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser>
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishGroup> DishGroups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}