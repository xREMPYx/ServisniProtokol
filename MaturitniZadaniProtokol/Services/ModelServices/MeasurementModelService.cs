using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services.ModelServices
{
    public class MeasurementModelService : IModelService
    {
        private IList<MeasurementModel> _model = new BindingList<MeasurementModel>();
        public IList<MeasurementModel> GetModel() => _model;

        public void Add()
        {
            MeasureForm form = new MeasureForm();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _model.Add(form.GetModel());
            }
        }

        public void Edit(int index)
        {
            MeasureForm form = new MeasureForm(_model[index]);

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _model[index] = form.GetModel();
            }
        }

        public void Remove(int index)
        {
            _model.RemoveAt(index);
        }

        public void Update(ProtocolModel model)
        {
            _model.Clear();
            model.Measurements.ToList().ForEach(x => _model.Add(x));
        }

        public void Save(ProtocolModel model)
        {
            model.Measurements = _model;
        }
    }
}