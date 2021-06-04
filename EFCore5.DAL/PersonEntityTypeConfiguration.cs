using EFCore5.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore5.DAL
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .ToTable("Persons", "dbo")
                .Ignore(p => p.FullName);

            builder
                .Property(p => p.Id)
                .HasColumnName("Person_Id");

            builder
                .Property(p => p.FirstName)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250)
                .IsRequired();

            builder
              .Property(p => p.EmailAddress)
              .HasColumnType("varchar(500)")
              .HasMaxLength(500)
              .IsRequired();

            builder
              .Property(p => p.CreatedOn)
              .HasDefaultValueSql("getdate()");

        }
    }
}
