﻿using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void DeleteAnbieterAsync(int id)
        {
            Anbieter anbieter = db.Anbieter.Find(id);
            if(anbieter != null)
            {
                db.Anbieter.Remove(anbieter);
                db.SaveChanges();
            }
        }

        public void CreateAnbieter(Anbieter anbieter)
        {
            db.Anbieter.Add(anbieter);
            db.SaveChanges();
        }

        public void UpdateAnbieter(Anbieter anbieter)
        {
            if(anbieter == null) return;
            db.Anbieter.Update(anbieter);
        }
    }
}
