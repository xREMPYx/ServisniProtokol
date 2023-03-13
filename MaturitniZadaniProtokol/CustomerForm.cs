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
    public partial class CustomerForm : Form
    {
        private readonly ValidationService _validationService;

        private CustomerModel _model = new();
        public CustomerModel GetModel() => _model;
        public CustomerForm()
        {
            InitializeComponent();
            this._validationService = new(this.ErrorProvider);
        }

        public CustomerForm(CustomerModel model) : this()
        {
            this.TxtBox_Address.Text = model.Address;
            this.TxtBox_Name.Text = model.Name;
            this.TxtBox_PostalCode.Text = model.PostalCode;
            this.TxtBox_TIN.Text = model.TIN;
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            _model.Address = this.TxtBox_Address.Text;
            _model.Name = this.TxtBox_Name.Text;
            _model.PostalCode = this.TxtBox_PostalCode.Text;
            _model.TIN = this.TxtBox_TIN.Text;

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

        private void TxtBox_PostalCode_Validating(object sender, CancelEventArgs e)
        {
            this._validationService.ValidateEmpty(sender, e);
            this._validationService.ValidatePostalCode(sender, e);
        }

        private void TxtBox_TIN_Validating(object sender, CancelEventArgs e)
        {
            this._validationService.ValidateEmpty(sender, e);
            this._validationService.ValidateTIN(sender, e);
        }
    }
}
