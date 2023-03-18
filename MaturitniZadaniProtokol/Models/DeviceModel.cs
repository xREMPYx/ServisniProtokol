using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaturitniZadaniProtokol.Models
{
    public class DeviceModel : BaseDrawableModel
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialCode { get; set; }

        public DeviceModel()
        {
            X = 370;
            Y = 100;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, X, Y, 310, 130);

            int pad = 20;

            graphics.DrawString("Zařízení", HeadingFont, Brushes.Black, X + 10, Y + 10);
            graphics.DrawString($"{"Výrobce:".PadRight(18)}{Manufacturer}", Font, Brushes.Black, X + 10, Y + pad * 2);
            graphics.DrawString($"{"Model:".PadRight(19)}{Model}", Font, Brushes.Black, X + 10, Y + pad * 3);
            graphics.DrawString($"{"Sériové číslo:".PadRight(17)}{SerialCode}", Font, Brushes.Black, X + 10, Y + pad * 4);                        
        }
    }
}
