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
    public partial class MeasureForm : Form
    {
        private readonly ValidationService _validationService;

        private MeasurementModel _model = new();
        public MeasurementModel GetModel() => this._model;

        public MeasureForm()
        {
            InitializeComponent();
            _validationService = new(this.ErrorProvider);
        }

        public MeasureForm(MeasurementModel model) : this()
        {
            this.TxtBox_Unit.Text = model.Unit;
            this.TxtBox_Parameter.Text = model.Parameter;
            this.TxtBox_Value.Text = model.Value;
            this.CheckBox_Suits.Checked = model.Suits;
        }        

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            
            this._model.Unit = this.TxtBox_Unit.Text;
            this._model.Value = this.TxtBox_Value.Text;
            this._model.Parameter = this.TxtBox_Parameter.Text;
            this._model.Suits = this.CheckBox_Suits.Checked;

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

        private void TxtBox_Value_Validating(object sender, CancelEventArgs e)
        {
            this._validationService.ValidateEmpty(sender, e);
            this._validationService.ValidateMeasureValue(sender, e);
        }
    }
}
