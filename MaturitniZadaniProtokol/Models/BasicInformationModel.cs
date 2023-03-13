using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class BasicInformationModel
    {
        public string ProtocolNumber { get; set; }
        public DateTime MeasurementDate { get; set; } = DateTime.Now;
    }
}
