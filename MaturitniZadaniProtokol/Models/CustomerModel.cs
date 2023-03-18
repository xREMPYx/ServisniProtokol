using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class CustomerModel : BaseDrawableModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string TIN { get; set; }

        public CustomerModel()
        {
            X = 20;
            Y = 100;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, X, Y, 310, 130);

            int pad = 20;

            graphics.DrawString("Zákazník", HeadingFont, Brushes.Black, X + 10, Y + 10);
            graphics.DrawString($"{"Název:".PadRight(15)}{Name}", Font, Brushes.Black, X + 10, Y + pad * 2);
            graphics.DrawString($"{"Adresa:".PadRight(15)}{Address}", Font, Brushes.Black, X + 10, Y + pad * 3);            
            graphics.DrawString($"{"PSČ:".PadRight(15)}{PostalCode}", Font, Brushes.Black, X + 10, Y + pad * 4);
            graphics.DrawString($"{"IČ:".PadRight(18)}{TIN}", Font, Brushes.Black, X + 10, Y + pad * 5);
        }
    }
}
