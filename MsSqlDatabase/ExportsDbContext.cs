using System;
using System.Configuration;
using System.Windows.Forms;

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
            catch (Exception) 
            {
                MessageBox.Show(
                    "Zły connectionString -> sprawdź App.config w DesktopView",
                    "Błąd krytyczny",
                    MessageBoxButtons.OK);

                Application.Exit();
            }
        }
    }
}
