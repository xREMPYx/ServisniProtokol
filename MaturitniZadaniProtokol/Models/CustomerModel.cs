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

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, 310, 130);

            int pad = 20;

            g.DrawString("Zákazník", HeadingFont, Brushes.Black, X + 10, Y + 10);
            g.DrawString($"{"Název:".PadRight(15)}{Name}", Font, Brushes.Black, X + 10, Y + pad * 2);
            g.DrawString($"{"Adresa:".PadRight(15)}{Address}", Font, Brushes.Black, X + 10, Y + pad * 3);            
            g.DrawString($"{"PSČ:".PadRight(15)}{PostalCode}", Font, Brushes.Black, X + 10, Y + pad * 4);
            g.DrawString($"{"IČ:".PadRight(18)}{TIN}", Font, Brushes.Black, X + 10, Y + pad * 5);
        }
    }
}
