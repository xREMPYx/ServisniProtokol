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

        
        public MainForm()
        {
            InitializeComponent();
            _customerService = new CustomerService(this);
            _deviceService = new DeviceService(this);
            _basicInfoService = new BasicInformationService(this);
            _measurementService = new MeasurementService(this);
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
    }
}