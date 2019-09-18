using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Belegung
    {
        public int MietvertragId { get; set; }
        public int StandplatzId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Mietvertrag Mietvertrag { get; set; }
        public virtual Standplatz Standplatz { get; set; }
    }
}
