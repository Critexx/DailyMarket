using System;
using System.Collections.Generic;

namespace DailyMarket
{
    public partial class Anbieter
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public bool? IsMitglied { get; set; }
    }
}
