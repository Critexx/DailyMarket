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

        public Task<Mitarbeiter> GetMitarbeiterAsync(int Id)
        {
            return Task.FromResult(db.Mitarbeiter.Find(Id));
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

        public void CreateMitarbeiter(Mitarbeiter Mitarbeiter)
        {
            Mitarbeiter.CreatedAt = DateTime.Now;
            db.Mitarbeiter.Add(Mitarbeiter);
            db.SaveChanges();
        }

        public void UpdateMitarbeiter(Mitarbeiter Mitarbeiter)
        {
            if(Mitarbeiter == null) return;
            Mitarbeiter.UpdatedAt = DateTime.Now;
            db.Mitarbeiter.Update(Mitarbeiter);
            db.SaveChanges();
        }
    }
}
