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
    public partial class DeviceForm : Form
    {
        private readonly ValidationService _validationService;

        private DeviceModel _model = new();
        public DeviceModel GetModel() => _model;

        public DeviceForm()
        {
            InitializeComponent();
            this._validationService = new(this.ErrorProvider);
        }

        public DeviceForm(DeviceModel model) : this()
        {
            this.TxtBox_Manufacturer.Text = model.Manufacturer;
            this.TxtBox_Model.Text = model.Model;
            this.TxtBox_SerialCode.Text = model.SerialCode;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            _model.Manufacturer = this.TxtBox_Manufacturer.Text;
            _model.Model = this.TxtBox_Model.Text;
            _model.SerialCode = this.TxtBox_SerialCode.Text;   

            this.DialogResult = DialogResult.OK;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtBox_EmptyValidating(object sender, CancelEventArgs e)
        {
            this._validationService.ValidateEmpty(sender, e);
        }
    }
}
