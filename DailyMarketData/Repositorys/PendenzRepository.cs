using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DailyMarketData.Repositorys
{
    public class PendenzRepository
    {
        private DailyMarketContext db { get; set; }
        public PendenzRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Pendenz>> GetPendenzAsync()
        {
            return Task.FromResult(db.Pendenz.ToList());
        }

        public Task<Pendenz> GetPendenzAsync(int id)
        {
            return db.Pendenz.Include(p => p.Rapport).ThenInclude(r => r.Mitarbeiter).SingleOrDefaultAsync(p => p.Id == id);
        }

        public void DeletePendenzAsync(int id)
        {
            Pendenz pendenz = db.Pendenz.Find(id);
            if (pendenz != null)
            {
                db.Pendenz.Remove(pendenz);
                db.SaveChanges();
            }
        }

        public void CreatePendenz(Pendenz pendenz)
        {
            pendenz.CreatedAt = DateTime.Now;
            db.Pendenz.Add(pendenz);
            db.SaveChanges();
        }

        public void UpdatePendenz(Pendenz pendenz)
        {
            if(pendenz == null) return;
            pendenz.UpdatedAt = DateTime.Now;
            db.Pendenz.Update(pendenz);
            db.SaveChanges();
        }
    }
}
