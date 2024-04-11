using CommonRepository;
using MockData;
using Model;
using MsSqlDatabase;
using MsSqlDatabase.Repositories;
using SimpleInjector;
using System;
using System.Windows.Forms;
using ViewLogic;
using ViewLogic.Interfaces;

namespace DXApplication2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Container container = new Container();
            Register(container, true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.GetInstance<IExportRaportService>()));
        }

        static private void Register(Container container, bool useRealDatabase)
        {
            if (useRealDatabase)
            {
                container.Register<ExportsDbContext, ExportsDbContext>();
                container.Register<IPlaceRepository<Place>, PlaceRepository>();
                container.Register<IExportRepository<Export>, ExportRepository>();
            }
            else
            {
                container.Register<MockDbContext, MockDbContext>();
                container.Register<IPlaceRepository<Place>, MockPlaceRepository>();
                container.Register<IExportRepository<Export>, MockExportRepository>();
            }

            container.Register<IExportRaportService, ExportRaportService>();
        }
    }
}
