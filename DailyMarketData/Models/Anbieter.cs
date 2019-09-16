using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Anbieter
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public bool IsMitglied { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
