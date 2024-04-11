using CommonRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MsSqlDatabase.Repositories
{
    public class PlaceRepository : IPlaceRepository<Place>
    {
        private readonly string _connectionString;
        public PlaceRepository(ExportsDbContext context)
        {
            _connectionString = context.ConnectionString;
        }

        public IQueryable<Place> GetAll()
        {
            var query = "SELECT * FROM Place";
            IList<Place> result = new List<Place>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();                

                try
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var place = new Place(
                            reader.GetInt32(0),
                            reader.GetString(1));

                        result.Add(place);
                    }
                }
                catch(Exception e)
                {

                }
            }

            return result.AsQueryable<Place>();
        }
    }
}
