using MaturitniZadaniProtokol.Models;
using MaturitniZadaniProtokol.Services;

namespace MaturitniZadaniProtokol
{
    public partial class MainForm : Form
    {
        private readonly CustomerService _customerService;

        private readonly DeviceService _deviceService;

        private readonly BasicInformationService _basicInfoService;

        private readonly MeasurementService _measurementService;

        private readonly FileService _fileService;

        private readonly PreviewService _previewService;

        private readonly HtmlExportService _exportService;

        
        public MainForm()
        {
            InitializeComponent();
            
            this._customerService = new CustomerService(this);
            this._deviceService = new DeviceService(this);
            this._basicInfoService = new BasicInformationService(this);

            this._measurementService = new MeasurementService();

            IModelService[] services = 
            { 
                _customerService, 
                _deviceService, 
                _basicInfoService, 
                _measurementService             
            };

            this._fileService = new FileService(services);
            this._previewService = new PreviewService(services);
            this._exportService = new HtmlExportService(services);

            this.DataGridView.DataSource = _measurementService.GetModel();
        }

        private void Btn_Info_Edit_Click(object sender, EventArgs e)
        {
            this._basicInfoService.Edit();
        }

        private void Btn_Customer_Edit_Click(object sender, EventArgs e)
        {
            this._customerService.Edit();            
        }

        private void Btn_Device_Edit_Click(object sender, EventArgs e)
        {
            this._deviceService.Edit();          
        }

        private void Btn_Measure_Add_Click(object sender, EventArgs e)
        {
            this._measurementService.Add();
        }

        private void Btn_Measure_Edit_Click(object sender, EventArgs e)
        {            
            if (_measurementService.GetModel().Count <= 0 || this.DataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            int index = this.DataGridView.CurrentRow.Index;

            this._measurementService.Edit(index);
        }

        private void Btn_Measure_Remove_Click(object sender, EventArgs e)
        {
            if (_measurementService.GetModel().Count <= 0 || this.DataGridView.SelectedRows.Count <= 0)
            {
                return;
            }

            int index = this.DataGridView.CurrentRow.Index;

            this._measurementService.Remove(index);
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            this._fileService.Save();
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            this._fileService.Import();
            this.DataGridView.Refresh();
        }

        private void Btn_Preview_Click(object sender, EventArgs e)
        {
            this._previewService.Preview();
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            this._exportService.Save();
        }
    }
}