using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Rapport
    {
        public int Id { get; set; }
        public int MitarbeiterId { get; set; }
        public int PendenzId { get; set; }
        public DateTime Datum { get; set; }
        public string Beschreibung { get; set; }
        public decimal Aufwand { get; set; }
        public decimal Stundensatz { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Mitarbeiter Mitarbeiter { get; set; }
        public virtual Pendenz Pendenz { get; set; }
    }
}
