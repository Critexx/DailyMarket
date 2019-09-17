using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Mitarbeiter
    {
        public Mitarbeiter()
        {
            Rapport = new HashSet<Rapport>();
        }

        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public decimal Stundensatz { get; set; }

        public virtual ICollection<Rapport> Rapport { get; set; }
    }
}
