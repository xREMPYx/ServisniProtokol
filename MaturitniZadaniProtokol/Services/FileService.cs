using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class FileService
    {
        private readonly IModelService[] _services;

        public FileService(params IModelService[] services)
        {
            this._services = services;
        }

        private string GetInformationText(BasicInformationModel model)
        {
            string result = $"[BasicInfo];{model.ProtocolNumber};{model.MeasurementDate}";

            return result;
        }

        private string GetCustomerText(CustomerModel model)
        {
            string result = $"[Customer];{model.Name};{model.Address};{model.PostalCode};{model.TIN}";

            return result;
        }

        private string GetDeviceText(DeviceModel model)
        {
            string result = $"[Device];{model.Manufacturer};{model.Model};{model.SerialCode}";

            return result;
        }

        private string GetMeasurementsText(IList<MeasurementModel> models)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[Measurements]");

            foreach (MeasurementModel model in models)
            {
                sb.AppendLine($"{model.Parameter};{model.Value};{model.SuitsText};{model.Unit}");
            }

            return sb.ToString();
        }        

        private BasicInformationModel GetInformationModel(string line)
        {
            string[] parts = line.Split(';');

            return new BasicInformationModel()
            {
                ProtocolNumber = parts[1],
                MeasurementDate = DateTime.Parse(parts[2])
            };
        }

        private CustomerModel GetCustomerModel(string line)
        {
            string[] parts = line.Split(';');

            return new CustomerModel()
            {
                Name = parts[1],
                Address = parts[2],
                PostalCode = parts[3],
                TIN = parts[4]
            };
        }

        private DeviceModel GetDeviceModel(string line)
        {
            string[] parts = line.Split(';');

            return new DeviceModel()
            {
                Manufacturer = parts[1],
                Model = parts[2],
                SerialCode = parts[3]
            };
        }

        private IList<MeasurementModel> GetMeasurementModels(string lines)
        {
            IList<MeasurementModel> result = new BindingList<MeasurementModel>();

            using (StringReader reader = new StringReader(lines))
            {
                reader.ReadLine();
                string? line = reader.ReadLine();
                                
                while (!string.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split(';');

                    result.Add(new MeasurementModel()
                    {
                        Parameter = parts[0],
                        Value = parts[1],
                        Suits = parts[2] == "ANO" ? true : false,
                        Unit = parts[3]
                    });

                    line = reader.ReadLine();
                }
            };

            return result;
        }

        private void Save(ProtocolModel model, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(GetInformationText(model.BasicInformation));
                writer.WriteLine(GetCustomerText(model.Customer));
                writer.WriteLine(GetDeviceText(model.Device));
                writer.WriteLine(GetMeasurementsText(model.Measurements));
            };
        }

        private ProtocolModel GetProtocolModel(string path)
        {
            ProtocolModel result = new ProtocolModel();

            using (StreamReader reader = new StreamReader(path))
            {
                result.BasicInformation = GetInformationModel(reader.ReadLine());
                result.Customer = GetCustomerModel(reader.ReadLine());
                result.Device = GetDeviceModel(reader.ReadLine());
                result.Measurements = GetMeasurementModels(reader.ReadToEnd());
            };
            
            return result;
        }

        public void Import()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    ProtocolModel model = GetProtocolModel(fileDialog.FileName);

                    foreach (IModelService service in _services)
                    {
                        service.Update(model);
                    }
                }
            };                        
        }

        public void Save()
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                ProtocolModel model = new ProtocolModel();

                fileDialog.Filter = "Text File | *.txt";

                foreach (IModelService service in _services)
                {
                    service.Save(model);
                }                

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Save(model, fileDialog.FileName);
                }
            };            
        }
    }
}
