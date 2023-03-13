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

        
        public MainForm()
        {
            InitializeComponent();
            _measurementService = new MeasurementService();
            _customerService = new CustomerService(this);
            _deviceService = new DeviceService(this);
            _basicInfoService = new BasicInformationService(this);
            _fileService = new FileService(_customerService, _deviceService, _basicInfoService, _measurementService);
            this.DataGridView.DataSource = _measurementService.GetModel();
        }

        private void Btn_Info_Edit_Click(object sender, EventArgs e)
        {
            _basicInfoService.Edit();
        }

        private void Btn_Customer_Edit_Click(object sender, EventArgs e)
        {
            _customerService.Edit();            
        }

        private void Btn_Device_Edit_Click(object sender, EventArgs e)
        {
            _deviceService.Edit();          
        }

        private void Btn_Measure_Add_Click(object sender, EventArgs e)
        {
            _measurementService.Add();
        }

        private void Btn_Measure_Edit_Click(object sender, EventArgs e)
        {
            int? index = this.DataGridView.CurrentCell.RowIndex;

            if (index == null || index < 0)
                return;

            _measurementService.Edit((int)index);
        }

        private void Btn_Measure_Remove_Click(object sender, EventArgs e)
        {
            int? index = this.DataGridView.CurrentCell.RowIndex;

            if (index == null || index < 0)
                return;

            _measurementService.Remove((int)index);
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            _fileService.Save();
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            _fileService.Import();
            this.DataGridView.Refresh();
        }
    }
}