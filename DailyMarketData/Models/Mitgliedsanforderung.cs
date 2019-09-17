using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Mitgliedsanforderung
    {
        public Mitgliedsanforderung()
        {
            MitgliedsanforderungAnbieter = new HashSet<MitgliedsanforderungAnbieter>();
            Pendenz = new HashSet<Pendenz>();
        }

        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Beschreibung { get; set; }
        public int? Gueltigkeitsdauer { get; set; }

        public virtual ICollection<MitgliedsanforderungAnbieter> MitgliedsanforderungAnbieter { get; set; }
        public virtual ICollection<Pendenz> Pendenz { get; set; }
    }
}
