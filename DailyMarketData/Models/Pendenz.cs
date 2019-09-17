using System;
using System.Collections.Generic;

namespace DailyMarketData.Models
{
    public partial class Pendenz
    {
        public Pendenz()
        {
            Rapport = new HashSet<Rapport>();
        }

        public int Id { get; set; }
        public int AnbieterId { get; set; }
        public int? MitgliedsanforderungId { get; set; }
        public string Titel { get; set; }
        public string Beschreibung { get; set; }
        public int Status { get; set; }

        public virtual Anbieter Anbieter { get; set; }
        public virtual Mitgliedsanforderung Mitgliedsanforderung { get; set; }
        public virtual ICollection<Rapport> Rapport { get; set; }
    }
}
