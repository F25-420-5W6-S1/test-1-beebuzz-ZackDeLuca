using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeBuzz.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Required]
        public int Id {  get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization? Organization { get; set; }

        public ICollection<Beehive> Users { get; set; } = new List<Beehive>();
    }
}
