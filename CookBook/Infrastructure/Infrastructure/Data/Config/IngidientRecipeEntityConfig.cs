using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class IngidientRecipeEntityConfig : IEntityTypeConfiguration<IngridientRecipe>
    {
        public void Configure(EntityTypeBuilder<IngridientRecipe> builder)
        {
            builder
                .ToTable("IngridientRecipe")
                .HasKey(xy => new { xy.IngridientId, xy.RecipeId });
            builder
                .HasOne(xy => xy.Ingridient)
                .WithMany(x => x.IngidientRecipe)
                .HasForeignKey(xy => xy.IngridientId);
            builder
                .HasOne(xy => xy.Recipe)
                .WithMany(y => y.IngidientRecipe)
                .HasForeignKey(xy => xy.RecipeId);
        }
    }
}

