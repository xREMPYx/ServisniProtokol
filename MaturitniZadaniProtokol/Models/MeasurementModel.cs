using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class MeasurementModel : BaseDrawableModel
    {
        [DisplayName("Parametr")]
        public string Parameter { get; set; }

        [DisplayName("Naměřená hodnota")]
        public string Value { get; set; }

        [DisplayName("Jednotka")]
        public string Unit { get; set; }
        
        [Browsable(false)]
        public bool Suits { get; set; }

        [DisplayName("Vyhovuje")]
        public string SuitsText
        {
            get 
            { 
                return Suits ? "ANO" : "NE"; 
            }
        }

        public MeasurementModel()
        {
            X = 20;
        }

        public override void Draw(Graphics g)
        {
            g.DrawString($"{Parameter}", Font, Brushes.Black, X, Y);
            g.DrawString($"{Value}", Font, Brushes.Black, X + 240, Y);
            g.DrawString($"{SuitsText}", Font, Brushes.Black, X + 500, Y);
        }
    }
}
