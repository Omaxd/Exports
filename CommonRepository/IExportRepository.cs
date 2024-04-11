using System;
using System.Linq;

namespace CommonRepository
{
    public interface IExportRepository<T> 
        where T : class
    {
        IQueryable<T> GetBetweenDatesForSelectedLocation(DateTime dateFrom, DateTime dateTo, int placeId);
    }
}
