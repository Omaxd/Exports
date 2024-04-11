using CommonRepository;
using Model;
using System;
using System.Linq;

namespace MockData
{
    public class MockExportRepository : IExportRepository<Export>
    {
        private readonly MockDbContext _dbContext;

        public MockExportRepository(MockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Export> GetBetweenDatesForSelectedLocation(
            DateTime dateFrom, 
            DateTime dateTo, 
            int placeId)
        {
            var result = _dbContext.Exports
                .Where(e => e.Date <= dateFrom)
                .Where(e => e.Date <= dateTo)
                .Where(e => e.PlaceId == placeId);

            return result.AsQueryable();
        }
    }
}
