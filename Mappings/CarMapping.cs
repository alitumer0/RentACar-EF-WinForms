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
    internal class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ModelID).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Kilometer).IsRequired();
            builder.Property(x => x.LicansePlate).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Color).IsRequired();
            builder.Property(x => x.Chassis).HasMaxLength(50).IsRequired();
            builder.Property(x => x.IsRented).IsRequired();
            builder.Property(x => x.HasInsurance).IsRequired();
            builder.Property(x => x.InsuranceLastDate).IsRequired();
            builder.Property(x => x.ExaminationLastDate).IsRequired();
            builder.Property(x => x.SeatCount).IsRequired();
            builder.Property(x => x.FuelType).IsRequired();
            builder.Property(x => x.GearBox).IsRequired();
            //Navigation Property
            builder.HasOne(x => x.Model).WithMany(x => x.Cars).HasForeignKey(x => x.ModelID);
        }
    }
}
