using System.Linq;

namespace CommonRepository
{
    public interface IPlaceRepository<T> 
        where T : class
    {
        IQueryable<T> GetAll();
    }
}
