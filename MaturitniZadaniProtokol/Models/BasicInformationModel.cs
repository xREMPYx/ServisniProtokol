using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class BasicInformationModel : BaseDrawableModel
    {
        public string ProtocolNumber { get; set; }
        public DateTime MeasurementDate { get; set; } = DateTime.Now;

        public BasicInformationModel()
        {
            X = 20;
            Y = 70;
        }

        public override void Draw(Graphics g)
        {            
            g.DrawString($"{"Datum měření:".PadRight(20)}{MeasurementDate.ToString("d.M.yyyy")}", Font, Brushes.Black, X, Y);
            g.DrawString($"{"Číslo protokolu:".PadRight(20)}{ProtocolNumber}", Font, Brushes.Black, X + 350, Y);            
        }
    }
}
