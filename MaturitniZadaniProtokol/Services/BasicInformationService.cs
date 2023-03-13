using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class BasicInformationService
    {
        private readonly MainForm _mainForm;

        private BasicInformationModel _model = new();
        public BasicInformationModel GetModel() => _model;

        public BasicInformationService(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Edit()
        {
            BasicInformationForm form = new BasicInformationForm(_model);

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _model = form.GetModel();

                _mainForm.Lbl_Protocol_Number.Text = _model.ProtocolNumber;
                _mainForm.Lbl_Measure_Date.Text = _model.MeasurementDate.ToString("d.M.yyyy");
            }
        }
    }
}
