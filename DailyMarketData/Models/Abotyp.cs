using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DailyMarketData.Models
{
    public partial class Abotyp
    {
        public Abotyp()
        {
            Mietvertrag = new HashSet<Mietvertrag>();
        }

        public int Id { get; set; }
        [Required]
        public string Bezeichnung { get; set; }
        public string Beschreibung { get; set; }
        [Required]
        public int Mietdauer { get; set; }
        [Required]
        public int AnzahlBelegungNoetig { get; set; }
        [Required]
        public DateTime GueltigVon { get; set; } = DateTime.Today;

        public DateTime? GueltigBis { get; set; }
        [Required]
        public decimal RabattInProzent { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Mietvertrag> Mietvertrag { get; set; }
    }
}
