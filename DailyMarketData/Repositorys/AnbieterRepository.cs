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
    public class AnbieterRepository
    {
        private DailyMarketContext db { get; set; }
        public AnbieterRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Anbieter>> GetAnbieterAsync()
        {
            return Task.FromResult(db.Anbieter.ToList());
        }

        public Task<Anbieter> GetAnbieterAsync(int id)
        {
            return db.Anbieter.Include(a => a.MitgliedsanforderungAnbieter).
                Include(a => a.Mietvertrag).ThenInclude(m => m.Belegungen).ThenInclude(b => b.Standplatz).ThenInclude(s => s.Standort).
                Include(a => a.Mietvertrag).ThenInclude(m => m.Abotyp).SingleAsync(a => a.Id == id);
        }

        public void DeleteAnbieterAsync(int id)
        {
            Anbieter anbieter = db.Anbieter.Find(id);
            if (anbieter != null)
            {
                db.Anbieter.Remove(anbieter);
                db.SaveChanges();
            }
        }

        public void CreateAnbieter(Anbieter anbieter)
        {
            anbieter.CreatedAt = DateTime.Now;
            db.Anbieter.Add(anbieter);
            db.SaveChanges();
        }

        public void UpdateAnbieter(Anbieter anbieter)
        {
            if(anbieter == null) return;
            anbieter.UpdatedAt = DateTime.Now;
            db.Anbieter.Update(anbieter);
            db.SaveChanges();
        }
    }
}
