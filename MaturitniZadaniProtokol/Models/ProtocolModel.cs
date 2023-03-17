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
        public BasicInformationModel BasicInformation { get; set; }
        public CustomerModel Customer { get; set; }
        public DeviceModel Device { get; set; }
        public IList<MeasurementModel> Measurements { get; set; }

        public ProtocolModel()
        {
            X = 20;
            Y = 300;
        }

        public override void Draw(Graphics g)
        {
            g.DrawString($"Potvrzení o provedení měření", HeadingFont, Brushes.Black, X + 180, 30);

            g.DrawString($"Parametr", Font, Brushes.Black, X, Y);
            g.DrawString($"Naměřená hodnota", Font, Brushes.Black, X + 240, Y);
            g.DrawString($"Vyhovuje", Font, Brushes.Black, X + 500, Y);

            int offsetY = 10;

            foreach (MeasurementModel model in Measurements)
            {
                offsetY += 20;
                model.SetY(Y + offsetY);
                model.Draw(g);
            }

            if (Measurements.All(x => x.Suits))
            {
                g.DrawString("Zařízení je schopné dalšího provozu", HeadingFont, Brushes.Black, X + 125, Y + offsetY + 35);
            }

            BasicInformation.Draw(g);
            Customer.Draw(g);
            Device.Draw(g);            
            g.DrawRectangle(Pens.Black, 10, 10, 680, 680);
        }
    }
}
