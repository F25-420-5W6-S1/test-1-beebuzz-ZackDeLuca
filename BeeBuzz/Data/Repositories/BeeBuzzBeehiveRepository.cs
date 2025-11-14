using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzBeehiveRepository : BeeBuzzGenericGenericRepository<Beehive>, IBeeBuzzGenericRepository<Beehive>
    {
        public BeeBuzzBeehiveRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Beehive>> logger) : base(db, logger)
        {
        }

        public async Task<List<Beehive>> GetBeehivesByUsers(int userId)
        {
            return await _context.Beehives
                .Where(beehive => beehive.UserId == userId)
                .ToListAsync();
        }
    }
}
