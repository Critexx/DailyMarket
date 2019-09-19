using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Standort
    {
        public Standort()
        {
            Standplaetze = new HashSet<Standplatz>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Strasse { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Standplatz> Standplaetze { get; set; }
    }
}
