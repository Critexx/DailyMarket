using System;
using System.Collections.Generic;
using System.Text;

namespace DailyMarket.constants
{
    static class AnbieterStatus
    {
        public static int Neu = 0;
        public static int Provisorisch = 1;
        public static int Mitglied = 2;

        public static Dictionary<int, string> StatusText { get; set; } = new Dictionary<int, string>()
        {
            {Neu, "Neu"},
            {Provisorisch, "Provisorisch"},
            {Mitglied, "Mitglied"},
        };
    }
}
