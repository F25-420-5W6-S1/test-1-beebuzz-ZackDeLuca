using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Interfaces
{
    public interface IBeeBuzzGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Update(T entity);
        void SaveAll();

        // Specific methods for the repository
        Task<List<Beehive>> GetBeehivesByUsers(int userId);
        Task<List<ApplicationUser>> GetUsersByOrganizationAsync(int organizationId);
    }
}
