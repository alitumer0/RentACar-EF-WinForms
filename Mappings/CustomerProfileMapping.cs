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
    internal class CustomerProfileMapping : IEntityTypeConfiguration<CustomerProfile>
    {
        public void Configure(EntityTypeBuilder<CustomerProfile> builder)
        {
            // Primary Key configuration is handled by Data Annotations

            // Property configurations
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.RelativeName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.RelativeType)
                .HasMaxLength(50)
                .IsRequired();

            // Configure BloodType enum
            builder.Property(x => x.BloodType)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();

            // Configure check constraint for BloodType
            builder.ToTable(t => t.HasCheckConstraint(
                "CK_BloodType",
                $"[BloodType] IN " +
                "('APositive', 'ANegative', 'BPositive', 'BNegative', " +
                "'ZeroPositive', 'ZeroNegative', 'ABPositive', 'ABNegative')"
            ));

            // Relationship configuration
            builder.HasOne(x => x.Customer)
                .WithOne(x => x.CustomerProfile)
                .HasForeignKey<CustomerProfile>(x => x.Id);
        }
    }
}
