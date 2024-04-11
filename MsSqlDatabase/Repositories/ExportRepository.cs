using CommonRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MsSqlDatabase.Repositories
{
    public class ExportRepository : IExportRepository<Export>
    {
        private readonly string _connectionString;

        public ExportRepository(ExportsDbContext context)
        {
            _connectionString = context.ConnectionString;
        }

        public IQueryable<Export> GetBetweenDatesForSelectedLocation(
            DateTime datefrom, 
            DateTime dateTo, 
            int placeId)
        {
            var query =
                "SELECT e.Name," +
                "   e.Time," +
                "   u.Name," +
                "   p.Name " +
                "FROM Export e " +
                "LEFT JOIN [User] u ON " +
                "   e.UserId = u.Id " +
                "LEFT JOIN Place p ON " +
                "   e.PlaceId = p.Id " +
                "WHERE e.PlaceId = @PlaceId AND " +
                "   Time BETWEEN  @DateFrom AND @DateTo";

            IList<Export> result = new List<Export>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.Add("@PlaceId", placeId);
                command.Parameters.Add("@DateFrom", datefrom);
                command.Parameters.Add("@DateTo", dateTo.AddDays(1));

                connection.Open();

                try
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var export = new Export(
                            reader.GetString(0),
                            reader.GetDateTime(1),
                            reader.GetString(2),
                            reader.GetString(3));

                        result.Add(export);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Problem z pobraniem tabeli Export z bazy danych",
                        "Błąd",
                        MessageBoxButtons.OK);
                }
            }

            return result.AsQueryable();
        }
    }
}
