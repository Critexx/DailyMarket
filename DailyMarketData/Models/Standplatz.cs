using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Standplatz
    {
        public Standplatz()
        {
            Belegung = new HashSet<Belegung>();
        }

        public int Id { get; set; }
        public int? StandortId { get; set; }
        public decimal? PreisProTag { get; set; }

        public virtual Standort Standort { get; set; }
        public virtual ICollection<Belegung> Belegung { get; set; }
    }
}
