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
    internal class RentMapping : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.ToTable("Rents");
            builder.HasKey(x => x.RentID);
            builder.Property(x => x.CustomerID).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CarID).HasMaxLength(50).IsRequired();
            builder.Property(x => x.StartRentDate).HasMaxLength(50).IsRequired();
            builder.Property(x => x.EndRentDate).HasMaxLength(50).IsRequired();
            //Navigation Property
            builder.HasOne(x => x.Customer).WithMany(x => x.Rents).HasForeignKey(x => x.CustomerID);
            builder.HasOne(x => x.Car).WithMany(x => x.Rents).HasForeignKey(x => x.CarID);
        }
    }
}
