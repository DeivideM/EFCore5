using System;
using EFCore5.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore5.DAL
{
    public class AddressEntityTypeConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {

            builder
                .Property(p => p.AddressLine1)
                .IsUnicode(false)
                .HasMaxLength(500)
                .IsRequired();

            builder
                .Property(p => p.AddressLine2)
                .IsUnicode(false)
                .HasMaxLength(500);

            builder
              .Property(p => p.City)
              .IsUnicode(false)
              .HasMaxLength(250)
              .IsRequired();

            builder
              .Property(p => p.State)
              .IsUnicode(false)
              .HasMaxLength(250)
              .IsRequired();

            builder
              .Property(p => p.Country)
              .IsUnicode(false)
              .HasMaxLength(250)
              .IsRequired();

            builder
              .Property(p => p.ZipCode)
              .IsUnicode(false)
              .HasMaxLength(50);

            builder
              .Property(p => p.CreatedOn)
              .HasDefaultValue(DateTime.Now);

        }
    }
}
