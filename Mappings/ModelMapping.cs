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
    internal class ModelMapping : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.ToTable("Models");
            builder.HasKey(x => x.ModelID);
            builder.Property(x => x.ModelName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.BrandID).HasMaxLength(50).IsRequired();
            //Navigation Property
            builder.HasOne(x => x.Brand).WithMany(x => x.models).HasForeignKey(x => x.BrandID);
        }
    }
}
