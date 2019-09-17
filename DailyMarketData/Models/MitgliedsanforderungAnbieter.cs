using System;

namespace DailyMarketData.Models
{
    public partial class MitgliedsanforderungAnbieter
    {
        public int Id { get; set; }
        public int MitgliedsanforderungId { get; set; }
        public int AnbieterId { get; set; }
        public DateTime GueltigAb { get; set; }
        public DateTime? GueltigBis { get; set; }
        public int Status { get; set; }

        public virtual Anbieter Anbieter { get; set; }
        public virtual Mitgliedsanforderung Mitgliedsanforderung { get; set; }
    }
}
