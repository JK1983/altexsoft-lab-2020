using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class RecipeEntityConfig : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder
                .ToTable("Recipes")
                .HasKey(x => x.Id);
            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(128);
            builder
                .Property(p => p.Description)
                .HasMaxLength(512);
            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Recipes)
                .HasForeignKey(p => p.CategoryId)
                .IsRequired();
            builder
                .HasMany(p => p.Steps)
                .WithOne(s => s.Recipe);
            builder
                .HasMany(r => r.IngidientRecipe)
                .WithOne(ir => ir.Recipe);
        }
    }
}

/*
         [Required, MaxLength(128)]
        public string Title { get; set; }
        [Required]
        public Category Category { get; set; }
        [MaxLength(512)]
        public string Description { get; set; }
        public List<IngridientRecipe> IngridientRecipe { get; set; } = new List<IngridientRecipe>();
        public List<Step> Steps { get; set; } = new List<Step>();
     */
