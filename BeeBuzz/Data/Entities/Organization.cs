namespace BeeBuzz.Data.Entities
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        required

        public string OrganizationName
        { get; set; }

        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
