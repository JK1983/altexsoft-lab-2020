using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class CategoryEntityConfig: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .ToTable("Categories")
                .HasKey(x => x.Id);
            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(128);
            builder
                .Property(p => p.Description)
                .HasMaxLength(512);
            builder
                .HasOne(p => p.ParentCategory)                
                .WithMany(c => c.ChildCategories)
                .HasForeignKey(p => p.ParentCategoryId)
                .IsRequired();
            builder
                .HasMany(p => p.Recipes)
                .WithOne(r => r.Category);
        }
    }
}

/*
		[Required]
		public int ParentCategoryId { get; set; }	
        public Category ParentCategory { get; set; }
		[Required, MaxLength(128)]
		public string Title { get; set; }
		[MaxLength(512)]
		public string Description { get; set; }
		public List<Category> ChildCategories { get; set; }
     */
