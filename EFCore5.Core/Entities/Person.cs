using System;
using System.Collections.Generic;

namespace EFCore5.Core.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string EmailAddress { get; set; }

        public DateTime CreatedOn { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

    }
}
