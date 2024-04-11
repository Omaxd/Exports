using Model;
using System;
using System.Linq;
using ViewLogic.Interfaces;

namespace DXApplication2
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private const int _pageSize = 100;
        private int _currentPage = 0;
        private int _maxPage = 0;

        private Export[] _exports;
        private readonly IExportRaportService _exportRaportController;
        

        public Form1(IExportRaportService exportRaportController)
        {
            _exportRaportController = exportRaportController;
            InitializeComponent();
            SetTextFields();

            deDateFrom.EditValue = DateTime.Now.AddDays(-7);
            deDateTo.EditValue = DateTime.Now;
            cbePlaces.Properties.Items.AddRange(_exportRaportController.GetPlaces());

            if ( cbePlaces.Properties.Items.Count > 0 )
            {
                cbePlaces.EditValue = cbePlaces.Properties.Items[0];
            }
            
            sbNext.Enabled = false;
            sbPrevious.Enabled = false;
        }

        private void SetTextFields()
        {
            gcExportName.Caption = "Nazwa";
            gcDate.Caption = "Data";
            gcTime.Caption = "Godzina";
            gcUser.Caption = "Użytkownik";
            gcPlace.Caption = "Lokal";

            lcPlaceName.Text = "Lokal:";
            lcDateFrom.Text = "Od:";
            lcDateTo.Text = "Do:";
            lcPage.Text = string.Empty;
            lcFoundExports.Text = string.Empty;

            sbNext.Text = "Następny";
            sbPrevious.Text = "Poprzedni";
            sbSubmit.Text = "Zatwierdź";

            this.Text = "Raport";
        }

        private void GetExportsForGridAndPrepareInformation()
        {
            gcExports.DataSource = _exports
                .Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize)
                .ToArray();

            sbPrevious.Enabled = _currentPage != 1;
            sbNext.Enabled = _maxPage != 1 && _currentPage != _maxPage;

            lcPage.Text = $"Strona {_currentPage} z {_maxPage}";
        }

        private void sbSubmit_Click(object sender, EventArgs e)
        {
            var dateFrom = (DateTime)deDateFrom.EditValue;
            var dateTo = (DateTime)deDateTo.EditValue;
            var checkedPlace = (Place)cbePlaces.EditValue;

            _exports = _exportRaportController.GetExports(dateFrom, dateTo, checkedPlace.Id);

            _currentPage = _exports.Length > 0 ? 1 : 0;
            _maxPage = (int)Math.Ceiling(_exports.Length / (double)_pageSize);

            lcFoundExports.Text = $"Znaleziono {_exports.Length} eksportów";

            GetExportsForGridAndPrepareInformation();
        }

        private void sbPrevious_Click(object sender, EventArgs e)
        {
            _currentPage--;
            GetExportsForGridAndPrepareInformation();
        }

        private void sbNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            GetExportsForGridAndPrepareInformation();
        }

        private void cbePlaces_BeforePopup(object sender, EventArgs e)
        {
            cbePlaces.Properties.Items.Clear();
            cbePlaces.Properties.Items.AddRange(_exportRaportController.GetPlaces());
        }
    }
}
