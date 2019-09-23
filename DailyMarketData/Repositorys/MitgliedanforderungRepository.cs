using DailyMarketData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DailyMarketData.Repositorys
{
    public class MitgliedsanforderungRepository
    {
        private DailyMarketContext db { get; set; }
        public MitgliedsanforderungRepository(DailyMarketContext db)
        {
            this.db = db;
        }

        public Task<List<Mitgliedsanforderung>> GetMitgliedsanforderungAsync()
        {
            var foo = db.Mitgliedsanforderung.ToList();
            return Task.FromResult(db.Mitgliedsanforderung.ToList());
        }

        public Task<Mitgliedsanforderung> GetMitgliedsanforderungAsync(int Id)
        {
            return Task.FromResult(db.Mitgliedsanforderung.Find(Id));
        }

        public void DeleteMitgliedsanforderungAsync(int id)
        {
            Mitgliedsanforderung mitgliedsanforderung = db.Mitgliedsanforderung.Find(id);
            if (mitgliedsanforderung != null)
            {
                db.Mitgliedsanforderung.Remove(mitgliedsanforderung);
                db.SaveChanges();
            }
        }

        public void CreateMitgliedsanforderung(Mitgliedsanforderung mitgliedsanforderung)
        {
            mitgliedsanforderung.CreatedAt = DateTime.Now;
            db.Mitgliedsanforderung.Add(mitgliedsanforderung);
            db.SaveChanges();
        }

        public void UpdateMitgliedsanforderung(IEnumerable<Mitgliedsanforderung> mitgliedsanforderungList)
        {
            db.Mitgliedsanforderung.UpdateRange(mitgliedsanforderungList);
            db.SaveChanges();
        }
    }
}
