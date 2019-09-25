using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DailyMarketData.Repositorys
{
    public class RapportRepository
    {
        private DailyMarketContext db { get; set; }
        public RapportRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Rapport>> GetRapportAsync()
        {
            return Task.FromResult(db.Rapport.ToList());
        }

        public Task<Rapport> GetRapportAsync(int id)
        {
            return Task.FromResult(db.Rapport.Find(id));
        }

        public void DeleteRapportAsync(int id)
        {
            Rapport rapport = db.Rapport.Find(id);
            if (rapport != null)
            {
                db.Rapport.Remove(rapport);
                db.SaveChanges();
            }
        }

        public void CreateRapport(Rapport rapport)
        {
            rapport.CreatedAt = DateTime.Now;
            db.Rapport.Add(rapport);
            db.SaveChanges();
        }

        public void UpdateRapport(Rapport rapport)
        {
            if(rapport == null) return;
            rapport.UpdatedAt = DateTime.Now;
            db.Rapport.Update(rapport);
            db.SaveChanges();
        }
    }
}
