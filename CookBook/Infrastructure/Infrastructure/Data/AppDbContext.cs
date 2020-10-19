using Core.Entities;
using Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Ingridient> Ingridients { get; set; }
        public DbSet<IngridientRecipe> IngridientRecipes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryEntityConfig());
            modelBuilder.ApplyConfiguration(new IngridientEntityConfig());
            modelBuilder.ApplyConfiguration(new IngidientRecipeEntityConfig());
            modelBuilder.ApplyConfiguration(new RecipeEntityConfig());
            modelBuilder.ApplyConfiguration(new StepEntityConfig());
        }
    }
}
