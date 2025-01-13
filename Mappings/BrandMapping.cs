using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_AracKiralama_WF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _10_AracKiralama_WF.Mappings
{
    internal class BrandMapping : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(x => x.BrandID);
            builder.Property(x => x.BrandName).HasMaxLength(50).IsRequired();
            //Navigation Property
            builder.HasMany(x => x.models).WithOne(x => x.Brand).HasForeignKey(x => x.BrandID);
        }
    }
}
