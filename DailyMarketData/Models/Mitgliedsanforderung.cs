using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<MitgliedsanforderungAnbieter> MitgliedsanforderungAnbieter { get; set; }
        public virtual ICollection<Pendenz> Pendenz { get; set; }
    }

    public class MitgliedsanforderungView
    {
        public string Bezeichnung { get; set; }
        public bool Erfuellt { get; set; } = false;
        public DateTime? GueltigBis { get; set; } 
    }
}
