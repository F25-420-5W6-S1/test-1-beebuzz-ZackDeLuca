using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzUserRepository : BeeBuzzGenericGenericRepository<ApplicationUser>, IBeeBuzzGenericRepository<ApplicationUser>
    {
        public BeeBuzzUserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<ApplicationUser>> logger) : base(db, logger)
        {
        }

    }
}
