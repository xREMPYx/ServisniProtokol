using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class DeviceService : IModelService
    {
        private readonly MainForm _mainForm;

        private DeviceModel _model = new();
        public DeviceModel GetModel() => _model;

        public DeviceService(MainForm mainForm)
        {
            _mainForm = mainForm;            
        }

        public void Edit()
        {
            DeviceForm form = new DeviceForm(_model);

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _model = form.GetModel();

                UpdateDisplayValues();
            }
        }

        public void Update(ProtocolModel model)
        {
            this._model = model.Device;
            UpdateDisplayValues();
        }

        public void Save(ProtocolModel model)
        {
            model.Device = _model;
        }

        private void UpdateDisplayValues()
        {
            _mainForm.Lbl_Device_Manufacturer.Text = _model.Manufacturer;
            _mainForm.Lbl_Device_Model.Text = _model.Model;
            _mainForm.Lbl_Device_SerialCode.Text = _model.SerialCode;
        }
    }
}
