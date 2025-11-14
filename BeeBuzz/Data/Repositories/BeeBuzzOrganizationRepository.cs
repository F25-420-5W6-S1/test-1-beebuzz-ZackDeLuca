using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzOrganizationRepository : BeeBuzzGenericGenericRepository<Organization>, IBeeBuzzGenericRepository<Organization>
    {
        public BeeBuzzOrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Organization>> logger) : base(db, logger)
        {
        }

        public async Task<List<ApplicationUser>> GetUsersByOrganizationAsync(int organizationId)
        {
            return await _context.Users
                .Where(user => user.OrganizationId == organizationId)
                .ToListAsync();
        }
    }
}
