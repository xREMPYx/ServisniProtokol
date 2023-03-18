using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class ProtocolModel : BaseDrawableModel
    {
        public InfoModel Info { get; set; }
        public CustomerModel Customer { get; set; }
        public DeviceModel Device { get; set; }
        public IList<MeasurementModel> Measurements { get; set; }

        public ProtocolModel()
        {
            X = 20;
            Y = 300;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawString($"Potvrzení o provedení měření", HeadingFont, Brushes.Black, X + 180, 30);

            graphics.DrawString($"Parametr", Font, Brushes.Black, X, Y);
            graphics.DrawString($"Naměřená hodnota", Font, Brushes.Black, X + 240, Y);
            graphics.DrawString($"Vyhovuje", Font, Brushes.Black, X + 500, Y);

            int offsetY = 10;

            foreach (MeasurementModel model in Measurements)
            {
                offsetY += 20;
                model.SetY(Y + offsetY);
                model.Draw(graphics);
            }

            if (Measurements.All(x => x.Suits))
            {
                graphics.DrawString("Zařízení je schopné dalšího provozu", HeadingFont, Brushes.Black, X + 125, Y + offsetY + 35);
            }
            else
            {
                graphics.DrawString("Zařízení není schopné dalšího provozu", HeadingFont, Brushes.Black, X + 122, Y + offsetY + 35);
            }

            Device.Draw(graphics);
            Customer.Draw(graphics);
            Info.Draw(graphics);            
               
            graphics.DrawRectangle(Pens.Black, 10, 10, 680, 680);
        }
    }
}
