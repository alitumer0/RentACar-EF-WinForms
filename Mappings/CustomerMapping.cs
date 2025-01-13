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
    internal class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure (EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.CustomerID);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CitizenID).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LisanceType).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CitizenID).HasMaxLength(50).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            

            //navigation property
            builder.HasOne(x => x.User).WithOne(x => x.Customer).HasForeignKey<Customer>(x => x.UserID);

            builder.HasOne(x => x.CustomerProfile).WithOne(x => x.Customer).HasForeignKey<CustomerProfile>(x => x.Id);

        }
    }
}
