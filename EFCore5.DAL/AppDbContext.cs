using System.Collections.Generic;
using EFCore5.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore5.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<LookUp> LookUps { get; set; }

        public AppDbContext() : base()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PersonEntityTypeConfiguration().Configure(modelBuilder.Entity<Person>());
            new AddressEntityTypeConfiguration().Configure(modelBuilder.Entity<Address>());

            modelBuilder.Seed();
        }
    }
}
