using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DailyMarket.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DailyMarketData.Repositorys
{
    public class MietvertragRepository
    {
        private DailyMarketContext db { get; set; }
        public MietvertragRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Mietvertrag>> GetMietvertragAsync()
        {
            var foo = db.Mietvertrag.ToList();
            return Task.FromResult(db.Mietvertrag.ToList());
        }

        public Task<Mietvertrag> GetMietvertragAsync(int id)
        {
            return Task.FromResult(db.Mietvertrag.Find(id));
        }

        public void DeleteMietvertragAsync(int id)
        {
            Mietvertrag Mietvertrag = db.Mietvertrag.Find(id);
            if (Mietvertrag != null)
            {
                db.Mietvertrag.Remove(Mietvertrag);
                db.SaveChanges();
            }
        }

        public void CreateMietvertrag(Mietvertrag Mietvertrag)
        {
            Mietvertrag.CreatedAt = DateTime.Now;
            foreach (Belegung belegung in Mietvertrag.Belegungen)
            {
                Mietvertrag.Abrechnung += belegung.Standplatz.PreisProTag.GetValueOrDefault() 
                                          * Mietvertrag.Abotyp.Mietdauer 
                                          * (Mietvertrag.Abotyp.RabattInProzent / 100 + 1);
            }
            db.Mietvertrag.Add(Mietvertrag);
            db.SaveChanges();
        }

        public void UpdateMietvertrag(Mietvertrag Mietvertrag)
        {
            if(Mietvertrag == null) return;
            Mietvertrag.UpdatedAt = DateTime.Now;
            db.Mietvertrag.Update(Mietvertrag);
            db.SaveChanges();
        }

        public Belegung GetBelegungIfPossible(int standortId, DateTime dateFrom, DateTime dateTo)
        {
            Standplatz standplatz = db.Standplatz.Where(s => s.StandortId == standortId).Include(s => s.Belegung).
                FirstOrDefault(s =>  s.Belegung.Any(b => !b.Mietvertrag.GueltigVon.IsBetween(dateFrom, dateTo) && !b.Mietvertrag.GueltigBis.Value.IsBetween(dateFrom, dateTo)));
            if (standplatz == null) return null;

            Belegung belegung = new Belegung()
            {
                Standplatz = standplatz
            };

            return belegung;
        }
    }
}
