using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Standort
    {
        public Standort()
        {
            Standplatz = new HashSet<Standplatz>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Strasse { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }

        public virtual ICollection<Standplatz> Standplatz { get; set; }
    }
}
