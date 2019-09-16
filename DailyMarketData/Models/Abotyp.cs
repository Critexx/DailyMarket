using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Abotyp
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Beschreibung { get; set; }
        public int Mietdauer { get; set; }
        public int AnzahlBelegungNoetig { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public decimal RabattInProzent { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
