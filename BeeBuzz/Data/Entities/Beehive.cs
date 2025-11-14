using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public bool IsActive { get; set; }

        public string DeactivationReason { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }
    }
}
