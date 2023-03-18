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

        public FileService(IModelService[] services)
        {
            this._services = services;
        }

        private string GetInformationText(InfoModel model)
        {
            return $"{model.ProtocolNumber};{model.MeasurementDate}";
        }

        private string GetCustomerText(CustomerModel model)
        {
            return $"{model.Name};{model.Address};{model.PostalCode};{model.TIN}";
        }

        private string GetDeviceText(DeviceModel model)
        {
            return $"{model.Manufacturer};{model.Model};{model.SerialCode}";
        }

        private string GetMeasurementsText(IEnumerable<MeasurementModel> models)
        {
            StringBuilder sb = new StringBuilder();

            foreach (MeasurementModel model in models)
            {
                sb.AppendLine($"{model.Parameter};{model.Value};{model.SuitsText};{model.Unit}");
            }

            return sb.ToString();
        }        

        private InfoModel GetInformationModel(string line)
        {
            string[] parts = line.Split(';');

            return new InfoModel()
            {
                ProtocolNumber = parts[0],
                MeasurementDate = DateTime.Parse(parts[1])
            };
        }

        private CustomerModel GetCustomerModel(string line)
        {
            string[] parts = line.Split(';');

            return new CustomerModel()
            {
                Name = parts[0],
                Address = parts[1],
                PostalCode = parts[2],
                TIN = parts[3]
            };
        }

        private DeviceModel GetDeviceModel(string line)
        {
            string[] parts = line.Split(';');

            return new DeviceModel()
            {
                Manufacturer = parts[0],
                Model = parts[1],
                SerialCode = parts[2]
            };
        }

        private IList<MeasurementModel> GetMeasurementModels(string lines)
        {
            IList<MeasurementModel> result = new BindingList<MeasurementModel>();

            using (StringReader reader = new StringReader(lines))
            {                
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
                    ProtocolModel model;

                    try
                    {
                        model = GetProtocolModel(fileDialog.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Zvolený soubor se nepodařilo zpracovat.");
                        return;
                    }

                    if (!ValidationService.IsProtocolValid(model))
                    {
                        MessageBox.Show("Zvolený soubor byl narušen.");
                        return;
                    }

                    foreach (IModelService service in _services)
                    {
                        service.Update(model);
                    }

                    MessageBox.Show("Soubor byl úspěšně nahrán.");
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
                    try
                    {
                        Save(model, fileDialog.FileName);
                        MessageBox.Show("Soubor byl úspěšně uložen.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Soubor se nepodařilo uložit.");
                    }
                }
            };            
        }
    }
}