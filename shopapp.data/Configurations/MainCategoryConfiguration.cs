using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Configurations
{
    public class MainCategoryConfiguration : IEntityTypeConfiguration<MainCategory>
    {
        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            builder.HasKey(m => m.MainCategoryId);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);

          
          
            // builder.Property(m=>m.DateAdded).HasDefaultValueSql ("date('now')");   // sqlite            
        }
    }
}
