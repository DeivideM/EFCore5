using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore5.Core.Entities
{
    [Table("Persons", Schema ="dbo")]
    public class Person
    {
        [Key]
        [Column("Person_Id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName ="varchar(255)")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string EmailAddress { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

    }
}
