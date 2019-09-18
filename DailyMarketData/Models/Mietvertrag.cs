using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Mietvertrag
    {
        public Mietvertrag()
        {
            Belegung = new HashSet<Belegung>();
        }

        public int Id { get; set; }
        public int AbotypId { get; set; }
        public int AnbieterId { get; set; }
        public DateTime GueltigVon { get; set; }
        public DateTime? GueltigBis { get; set; }
        public decimal Abrechnung { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Abotyp Abotyp { get; set; }
        public virtual Anbieter Anbieter { get; set; }
        public virtual ICollection<Belegung> Belegung { get; set; }
    }
}
