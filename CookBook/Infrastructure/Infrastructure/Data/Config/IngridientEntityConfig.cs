using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class IngridientEntityConfig : IEntityTypeConfiguration<Ingridient>
    {
        public void Configure(EntityTypeBuilder<Ingridient> builder)
        {
            builder
                .ToTable("Ingridients")
                .HasKey(x => x.Id);
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(128);
            builder
                .Property(p => p.Description)
                .HasMaxLength(512);
            builder
                .HasMany(p => p.IngidientRecipe)
                .WithOne(ir => ir.Ingridient);
        }
    }
}

