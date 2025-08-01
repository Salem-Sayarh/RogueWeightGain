using Microsoft.EntityFrameworkCore;
using RWG.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RWG.Data
{
    /// <summary>
    /// Represents the database context for managing meal-related data in the application.
    /// </summary>
    public class MealContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "meals.db");
            options.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Enums to be stored as integers by default
            modelBuilder.Entity<Meal>()
                .Property(m => m.TypeTag)
                .HasConversion<int>();

            modelBuilder.Entity<Meal>()
                .Property(m => m.Difficulty)
                .HasConversion<int>();

            // Index on Title for quick lookup
            modelBuilder.Entity<Meal>()
                .HasIndex(m => m.Title);
        }
    }
}
