using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Abotyp
    {
        public int Id { get; set; }
        [Required]
        public string Bezeichnung { get; set; }
        public string Beschreibung { get; set; }
        [Required]
        public int Mietdauer { get; set; }
        [Required]
        public int AnzahlBelegungNoetig { get; set; }
        [Required]
        public DateTime GueltigVon { get; set; }
        [Required]
        public DateTime? GueltigBis { get; set; }
        [Required]
        public decimal RabattInProzent { get; set; } = 0;
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
