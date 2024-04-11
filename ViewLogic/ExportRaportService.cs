using CommonRepository;
using Model;
using System;
using System.Linq;
using ViewLogic.Interfaces;

namespace ViewLogic
{
    public class ExportRaportService : IExportRaportService
    {
        private IExportRepository<Export> _exportRepository;
        private IPlaceRepository<Place> _placesRepository;        

        public ExportRaportService(
            IExportRepository<Export> exportRepository,
            IPlaceRepository<Place> placesRepository) 
        {
            _exportRepository = exportRepository;
            _placesRepository = placesRepository;
        }

        public Place[] GetPlaces()
        {
            return (Place[])_placesRepository
                .GetAll()
                .OrderBy(p => p.Name)
                .ToArray();
        }

        public Export[] GetExports(DateTime dateFrom, DateTime dateTo, int placeId)
        {
            return (Export[])_exportRepository
                .GetBetweenDatesForSelectedLocation(dateFrom, dateTo, placeId)
                .OrderBy(p => p.Name)
                .ToArray();
        }
    }
}
