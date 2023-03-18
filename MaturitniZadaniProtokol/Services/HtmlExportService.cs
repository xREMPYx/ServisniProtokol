using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class HtmlExportService
    {
        private readonly IModelService[] _services;

        public HtmlExportService(IModelService[] services)
        {
            this._services = services;
        }

        private string GetPageHtml(ProtocolModel model)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<head>");
            stringBuilder.AppendLine("<html>");
            stringBuilder.AppendLine("<style>");
            stringBuilder.AppendLine(GetStyles());
            stringBuilder.AppendLine("</style>");
            stringBuilder.AppendLine("</head>");
            stringBuilder.AppendLine("<body>");

            stringBuilder.AppendLine("<div id='protokol'>");  
            
            stringBuilder.AppendLine("<h1>Potvrzení o provedení měření</h1>");
            stringBuilder.AppendLine(GetBasicInformations(model.BasicInformation));
            stringBuilder.AppendLine(GetCustomer(model.Customer));
            stringBuilder.AppendLine(GetDevice(model.Device));
            stringBuilder.AppendLine(GetMeasurements(model.Measurements));

            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine("</body>");
            stringBuilder.AppendLine("</html>");

            return stringBuilder.ToString();
        }

        private string GetBasicInformations(InfoModel model)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<div id='datum'>Datum měření: {model.MeasurementDate} </div>");
            stringBuilder.AppendLine($"<div id='cisloProtokolu'>Číslo protokolu: {model.ProtocolNumber}</div>");

            return stringBuilder.ToString();
        }

        private string GetCustomer(CustomerModel model)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div id='zakaznik'>");
            stringBuilder.AppendLine("<h2>Zákazník</h2>");
            stringBuilder.AppendLine($"<div>Název: {model.Name}</div>");
            stringBuilder.AppendLine($"<div>Adresa: {model.Address}</div>");
            stringBuilder.AppendLine($"<div>PSČ: {model.PostalCode}</div>");
            stringBuilder.AppendLine($"<div>IČ: {model.TIN}</div>");
            stringBuilder.AppendLine($"</div>");

            return stringBuilder.ToString();
        }

        private string GetDevice(DeviceModel model)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<div id='zarizeni'>");
            stringBuilder.AppendLine($"<h2>Zařízení</h2>");
            stringBuilder.AppendLine($"<div>Výrobce: {model.Manufacturer}</div>");
            stringBuilder.AppendLine($"<div>Model: {model.Model}</div>");
            stringBuilder.AppendLine($"<div>Sériové číslo: {model.SerialCode}</div>");
            stringBuilder.AppendLine($"</div>");

            return stringBuilder.ToString();
        }

        private string GetMeasurements(IEnumerable<MeasurementModel> models)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<div id='mereni'>");
            stringBuilder.AppendLine($"<h2>Měření</h2>");
            stringBuilder.AppendLine($"<table>");
            stringBuilder.AppendLine($"<tr>");
            stringBuilder.AppendLine($"<th>Parametr</th>");
            stringBuilder.AppendLine($"<th>Naměřená hodnota</th>");
            stringBuilder.AppendLine($"<th>Vyhovuje</th>");            
            stringBuilder.AppendLine($"</tr>");            

            foreach (MeasurementModel model in models)
            {
                stringBuilder.AppendLine($"</tr>");
                stringBuilder.AppendLine($"<td>{model.Parameter}</td>");
                stringBuilder.AppendLine($"<td>{model.Value}{model.Unit}</td>");
                stringBuilder.AppendLine($"<td>{model.SuitsText}</td>");
                stringBuilder.AppendLine($"</tr>");
            }
            
            stringBuilder.AppendLine($"</table>");
            stringBuilder.AppendLine($"</div>");

            if (models.All(x => x.Suits))
            {
                stringBuilder.AppendLine($"<div id='zaver'>Zařízení je schopné dalšího provozu</div>");
            }
            else
            {
                stringBuilder.AppendLine($"<div id='zaver'>Zařízení není schopné dalšího provozu</div>");
            }

            return stringBuilder.ToString();
        }

        private string GetStyles()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("h1 { text-align:center; }");
            stringBuilder.AppendLine("div#protokol { margin:2em; border:1px solid black; }");
            stringBuilder.AppendLine("div#datum { float:left; margin:1em; width:40%;  }");
            stringBuilder.AppendLine("div#cisloProtokolu { text-align:right; float:right; margin:1em; width:40%; }");
            stringBuilder.AppendLine("div#zaver { text-align:center; font-weight:bold; font-size:1.2em; }");
            stringBuilder.AppendLine("div#zakaznik { border:1px solid black; margin:1em; padding:1em; width:40%; float:left; height: 140px;}");
            stringBuilder.AppendLine("div#zarizeni { border:1px solid black; margin:1em; padding:1em; width:40%; float:right; height: 140px;}");
            stringBuilder.AppendLine("div#mereni { clear:both; padding:1em; }");
            stringBuilder.AppendLine("div#mereni table { width:100%; }");
            stringBuilder.AppendLine("div#mereni table th { text-align:left; }");

            return stringBuilder.ToString();
        }

        public void Save()
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                ProtocolModel model = new ProtocolModel();

                fileDialog.Filter = "Html File | *.html";

                foreach (IModelService service in _services)
                {
                    service.Save(model);
                }

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    File.WriteAllText(fileDialog.FileName, GetPageHtml(model));
                }
            };
        }
    }
}