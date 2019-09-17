using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Belegung
    {
        public int MietvertragId { get; set; }
        public int StandplatzId { get; set; }

        public virtual Mietvertrag Mietvertrag { get; set; }
        public virtual Standplatz Standplatz { get; set; }
    }
}
