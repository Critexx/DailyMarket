using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DailyMarketData.Repositorys
{
    public class MitarbeiterRepository
    {
        private DailyMarketContext db { get; set; }
        public MitarbeiterRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Mitarbeiter>> GetMitarbeiterAsync()
        {
            var foo = db.Mitarbeiter.ToList();
            return Task.FromResult(db.Mitarbeiter.ToList());
        }

        public Task<Mitarbeiter> GetMitarbeiterAsync(int id)
        {
            return Task.FromResult(db.Mitarbeiter.Find(id));
        }

        public void DeleteMitarbeiterAsync(int id)
        {
            Mitarbeiter Mitarbeiter = db.Mitarbeiter.Find(id);
            if (Mitarbeiter != null)
            {
                db.Mitarbeiter.Remove(Mitarbeiter);
                db.SaveChanges();
            }
        }

        public void CreateMitarbeiter(Mitarbeiter mitarbeiter)
        {
            mitarbeiter.CreatedAt = DateTime.Now;
            db.Mitarbeiter.Add(mitarbeiter);
            db.SaveChanges();
        }

        public void UpdateMitarbeiter(Mitarbeiter mitarbeiter)
        {
            if(mitarbeiter == null) return;
            mitarbeiter.UpdatedAt = DateTime.Now;
            db.Mitarbeiter.Update(mitarbeiter);
            db.SaveChanges();
        }
    }
}
