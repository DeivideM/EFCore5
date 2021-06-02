using System.ComponentModel.DataAnnotations;

namespace EFCore5.Core.Entities
{
    public class LookUp
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public LookUpType LookUpType { get; set; }
    }
}
