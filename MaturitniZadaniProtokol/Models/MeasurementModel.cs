using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public class MeasurementModel
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
                
    }
}
