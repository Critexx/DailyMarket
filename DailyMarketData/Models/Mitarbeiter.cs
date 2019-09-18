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
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Rapport> Rapport { get; set; }
    }
}
