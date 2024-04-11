using System;
using System.Configuration;

namespace MsSqlDatabase
{
    public class ExportsDbContext
    {
        public string ConnectionString { get; set; }

        public ExportsDbContext()
        {
            try
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
            }
            catch (Exception e) 
            {
            }
        }
    }
}
