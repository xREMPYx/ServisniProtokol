using MaturitniZadaniProtokol.Models;
using MaturitniZadaniProtokol.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaturitniZadaniProtokol
{
    public partial class BasicInformationForm : Form
    {
        private readonly ValidationService _validationService;

        private BasicInformationModel _model = new ();
        public BasicInformationModel GetModel() => _model;

        public BasicInformationForm()
        {
            InitializeComponent();
            this._validationService = new(this.ErrorProvider);
        }

        public BasicInformationForm(BasicInformationModel model) : this()
        {
            this.TxtBox_ProtocolNumber.Text = model.ProtocolNumber;
            this.DateTimePicker_Measure_Date.Value = model.MeasurementDate;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            _model.ProtocolNumber = this.TxtBox_ProtocolNumber.Text;
            _model.MeasurementDate = this.DateTimePicker_Measure_Date.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtBox_ProtocolNumber_Validating(object sender, CancelEventArgs e)
        {
            this._validationService.ValidateEmpty(sender, e);
        }
    }
}
