using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class ProtocolModel
    {
        public BasicInformationModel BasicInformation { get; set; }
        public CustomerModel Customer { get; set; }
        public DeviceModel Device { get; set; }
        public IList<MeasurementModel> Measurements { get; set; }
    }
}
