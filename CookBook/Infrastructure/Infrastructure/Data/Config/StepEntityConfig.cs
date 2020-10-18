using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class StepEntityConfig : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder
                .ToTable("Steps")
                .HasKey(x => x.Id);
            builder
                .Property(p => p.OrderNum)
                .IsRequired();
            builder
                .Property(p => p.Description)
                .HasMaxLength(512);
            builder
                .HasOne(p => p.Recipe)
                .WithMany(r => r.Steps)
                .HasForeignKey(p => p.RecipeId)
                .IsRequired();
        }
    }
}
/*
         [Required]
        public int RecipeId { get; set; }
        [Required]
        public Recipe Recipe { get; set; } //I don't need it
        [Required]
        public int OrderNum { get; set; }
        [MaxLength(512)]
        public string Description { get; set; }
     */
