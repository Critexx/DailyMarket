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
    public class StandortRepository
    {
        private DailyMarketContext db { get; set; }
        public StandortRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Standort>> GetStandortAsync()
        {
            return db.Standort.Include(x => x.Standplaetze).ToListAsync();
        }

        public Task<Standort> GetStandortAsync(int Id)
        {
            return db.Standort.Include(x => x.Standplaetze).SingleOrDefaultAsync(x => x.Id == Id);
        }

        public void DeleteStandortAsync(int id)
        {
            Standort standort = db.Standort.Find(id);
            if (standort != null)
            {
                db.Standort.Remove(standort);
                db.SaveChanges();
            }
        }

        public void CreateStandort(Standort standort)
        {
            List<Standplatz> standplaetze = new List<Standplatz>();
            for (int i = 1; i <= standort.AnzahlStandplaetze; i++)
            {
                standplaetze.Add(new Standplatz()
                {
                    Nr = i,
                    PreisProTag = standort.PreisProTag,
                    CreatedAt = DateTime.Now,
                    CreatedBy = standort.CreatedBy
                });
            }

            standort.Standplaetze = standplaetze;
            standort.CreatedAt = DateTime.Now;
            db.Standort.Add(standort);
            db.SaveChanges();
        }

        public void UpdateStandort(Standort standort)
        {
            if(standort == null) return;
            foreach (Standplatz standplatz in standort.Standplaetze)
            {
                standplatz.UpdatedAt = DateTime.Now;
                standplatz.UpdatedBy = standort.UpdatedBy;
            }
            standort.UpdatedAt = DateTime.Now;
            db.Standort.Update(standort);
            db.SaveChanges();
        }
    }
}
