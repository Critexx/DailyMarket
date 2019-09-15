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
        public int GueltigVon { get; set; }
        public int? GueltigBis { get; set; }
        public decimal RabattInProzent { get; set; }
    }
}
