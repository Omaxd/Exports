using CommonRepository;
using Model;
using System.Linq;

namespace MockData
{
    public class MockPlaceRepository : IPlaceRepository<Place>
    {
        private readonly MockDbContext _dbContext;

        public MockPlaceRepository(MockDbContext dbContext)
        { 
            _dbContext = dbContext;
        }
        
        public IQueryable<Place> GetAll()
        {            
            return _dbContext.Places.AsQueryable();
        }
    }
}
