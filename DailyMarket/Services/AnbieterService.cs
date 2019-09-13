using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyMarketData;
using DailyMarketData.Models;

namespace DailyMarket.Services
{
    public class AnbieterService
    {
        private DailyMarketContext db { get; set; }
        public AnbieterService(DailyMarketContext foo)
        {
            this.db = db;
        }

        public Task<Anbieter[]> GetAnbieterAsync()
        {
            DailyMarketContext db = new DailyMarketContext();
            
            return Task.FromResult(db.Anbieter.ToArray());
        }
    }
}