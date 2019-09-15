using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DailyMarketData.Repositorys
{
    public class AbotypRepository
    {
        private DailyMarketContext db { get; set; }
        public AbotypRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Abotyp>> GetAbotypAsync()
        {
            return Task.FromResult(db.Abotyp.ToList());
        }

        public Task<Abotyp> GetAbotypAsync(int id)
        {
            return Task.FromResult(db.Abotyp.Find(id));
        }

        public void DeleteAbotypAsync(int id)
        {
            Abotyp abotyp = db.Abotyp.Find(id);
            if (abotyp != null)
            {
                db.Abotyp.Remove(abotyp);
                db.SaveChanges();
            }
        }

        public void CreateAbotyp(Abotyp abotyp)
        {
            db.Abotyp.Add(abotyp);
            db.SaveChanges();
        }

        public void UpdateAbotyp(Abotyp abotyp)
        {
            if(abotyp == null) return;
            db.Abotyp.Update(abotyp);
        }
    }
}
