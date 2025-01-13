using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_AracKiralama_WF.Entities;
using _10_AracKiralama_WF.Mappings;
using Microsoft.EntityFrameworkCore;

namespace _10_AracKiralama_WF.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Model> Models { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Car> cars { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerProfile> CustomersProfile { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet <Rent> Rents { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ALITUMER;Database=AracKiralamaDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMapping());
            modelBuilder.ApplyConfiguration(new ModelMapping());
            modelBuilder.ApplyConfiguration(new BrandMapping());
            modelBuilder.ApplyConfiguration(new RentMapping());
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            modelBuilder.ApplyConfiguration(new CustomerProfileMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());

        }



    }            
}
