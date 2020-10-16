using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class TempEntityConfig : IEntityTypeConfiguration<TempEntity>
    {
        public void Configure(EntityTypeBuilder<TempEntity> builder)
        {
            builder
                .HasKey(x => x.Id);
        }
    }
}
