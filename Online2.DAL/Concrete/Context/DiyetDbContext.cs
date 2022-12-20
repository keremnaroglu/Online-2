using Microsoft.EntityFrameworkCore;
using Online2.DAL.Concrete.Context.Configurations;
using Online2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.DAL.Concrete.Context
{
    public class DiyetDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-SRVROOJ\SQLSERVER2019 ; Database= Diyet; Trusted_Connection= True;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MealFood> MealFoods { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration())
                        .ApplyConfiguration(new MealConfiguration())
                        .ApplyConfiguration(new CategoryConfiguration())
                        .ApplyConfiguration(new FoodConfiguration())
                        .ApplyConfiguration(new MealFoodConfiguration());
        }

    }
}
