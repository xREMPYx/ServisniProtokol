using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services.ModelServices
{
    public class InfoModelService : IModelService
    {
        private readonly MainForm _mainForm;

        private InfoModel _model = new();
        public InfoModel GetModel() => _model;

        public InfoModelService(MainForm mainForm)
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

                UpdateValues();
            }
        }

        public void Update(ProtocolModel model)
        {
            _model = model.Info;

            UpdateValues();
        }

        public void Save(ProtocolModel model)
        {
            model.Info = _model;
        }

        private void UpdateValues()
        {
            _mainForm.Lbl_Protocol_Number.Text = _model.ProtocolNumber;
            _mainForm.Lbl_Measure_Date.Text = _model.MeasurementDate.ToString("d.M.yyyy");
        }
    }
}