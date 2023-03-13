using MaturitniZadaniProtokol.Models;
using MaturitniZadaniProtokol.Services;

namespace MaturitniZadaniProtokol
{
    public partial class MainForm : Form
    {
        private readonly CustomerService _customerService;

        private readonly DeviceService _deviceService;

        private readonly BasicInformationService _basicInfoService;
        public MainForm()
        {
            InitializeComponent();
            _customerService = new CustomerService(this);
            _deviceService = new DeviceService(this);
            _basicInfoService = new BasicInformationService(this);
        }

        private void Btn_Info_Edit_Click(object sender, EventArgs e)
        {
            _basicInfoService.Edit();

            BasicInformationModel model = _basicInfoService.GetModel();

            this.Lbl_Protocol_Number.Text = model.ProtocolNumber;
            this.Lbl_Measure_Date.Text = model.MeasurementDate.ToString("d.M.yyyy");
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
            
        }

        private void Btn_Measure_Edit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Measure_Remove_Click(object sender, EventArgs e)
        {

        }
    }
}