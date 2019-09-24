using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyMarketData.Models
{
    public partial class Anbieter
    {
        public Anbieter()
        {
            Mietvertrag = new HashSet<Mietvertrag>();
            MitgliedsanforderungAnbieter = new HashSet<MitgliedsanforderungAnbieter>();
            Pendenz = new HashSet<Pendenz>();
            Fullname = $"{Vorname} {Nachname}";
        }

        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public bool IsMitglied { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        [NotMapped]
        public string Fullname { get; set; }

        public virtual ICollection<Mietvertrag> Mietvertrag { get; set; }
        public virtual ICollection<MitgliedsanforderungAnbieter> MitgliedsanforderungAnbieter { get; set; }
        public virtual ICollection<Pendenz> Pendenz { get; set; }
    }
}
