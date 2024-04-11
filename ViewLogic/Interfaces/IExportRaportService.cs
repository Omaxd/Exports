using Model;
using System;

namespace ViewLogic.Interfaces
{
    public interface IExportRaportService
    {
        Place[] GetPlaces();
        Export[] GetExports(DateTime dateFrom, DateTime dateTo, int placeId);
    }
}
