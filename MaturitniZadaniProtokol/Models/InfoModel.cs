using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class InfoModel : BaseDrawableModel
    {
        public string ProtocolNumber { get; set; }
        public DateTime MeasurementDate { get; set; } = DateTime.Now;

        public InfoModel()
        {
            X = 20;
            Y = 70;
        }

        public override void Draw(Graphics graphics)
        {            
            graphics.DrawString($"{"Datum měření:".PadRight(20)}{MeasurementDate.ToString("d.M.yyyy")}", Font, Brushes.Black, X, Y);
            graphics.DrawString($"{"Číslo protokolu:".PadRight(20)}{ProtocolNumber}", Font, Brushes.Black, X + 350, Y);            
        }
    }
}
