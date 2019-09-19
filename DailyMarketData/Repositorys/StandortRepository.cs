using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DailyMarketData.Repositorys
{
    public class StandortRepository
    {
        private DailyMarketContext db { get; set; }
        public StandortRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Standort>> GetStandortAsync()
        {
            return Task.FromResult(db.Standort.ToList());
        }

        public Task<Standort> GetStandortAsync(int Id)
        {
            return Task.FromResult(db.Standort.Find(Id));
        }

        public void DeleteStandortAsync(int id)
        {
            Standort Standort = db.Standort.Find(id);
            if (Standort != null)
            {
                db.Standort.Remove(Standort);
                db.SaveChanges();
            }
        }

        public void CreateStandort(Standort Standort)
        {
            Standort.CreatedAt = DateTime.Now;
            db.Standort.Add(Standort);
            db.SaveChanges();
        }

        public void UpdateStandort(Standort Standort)
        {
            if(Standort == null) return;
            Standort.UpdatedAt = DateTime.Now;
            db.Standort.Update(Standort);
        }
    }
}
