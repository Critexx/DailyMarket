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
            return db.Pendenz.Include(p => p.Anbieter).Include(p => p.Mitgliedsanforderung).ToListAsync();
        }

        public Task<Pendenz> GetPendenzAsync(int id)
        {
            return db.Pendenz.Include(p => p.Rapport).
                ThenInclude(r => r.Mitarbeiter).
                Include(p => p.Mitgliedsanforderung).
                SingleOrDefaultAsync(p => p.Id == id);
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

            // wenn die Pendenz abgeschlossen wird, dann muss auf Mitgliedanforderung geschaut werden.
            if (!pendenz.IsOffen && pendenz.MitgliedsanforderungId != null)
            {
                AddOrUpdateMitgliedsanforderungAnbieter(pendenz);
            }
            db.SaveChanges();
        }

        /// <summary>
        /// Setzt oder Updatet die Verknüpfung zwischen Anbieter und Mitgliedsanforderung. Bei einem Update wird die Gültigkeit
        /// um die Zeit erhöht, wie sie in der Mitgliedsanforderung definiert ist.
        /// </summary>
        private void AddOrUpdateMitgliedsanforderungAnbieter(Pendenz pendenz)
        {
            MitgliedsanforderungAnbieter mitgliedsanforderungAnbieter = db.MitgliedsanforderungAnbieter.SingleOrDefault(x =>
                x.AnbieterId == pendenz.AnbieterId &&
                x.MitgliedsanforderungId == pendenz.MitgliedsanforderungId);

            Mitgliedsanforderung anforderung = db.Mitgliedsanforderung.Find(pendenz.MitgliedsanforderungId);
            if(anforderung == null) return;
            
            DateTime gueltigBis = DateTime.Today.AddDays(anforderung.Gueltigkeitsdauer.GetValueOrDefault());
            if (mitgliedsanforderungAnbieter == null)
            {
                mitgliedsanforderungAnbieter =
                    new MitgliedsanforderungAnbieter
                    {
                        AnbieterId = pendenz.AnbieterId,
                        MitgliedsanforderungId = anforderung.Id,
                        GueltigAb = DateTime.Today,
                        CreatedAt = DateTime.Now,
                        CreatedBy = pendenz.UpdatedBy,
                        GueltigBis = gueltigBis,
                        Status = 0
                    };
                db.MitgliedsanforderungAnbieter.Add(mitgliedsanforderungAnbieter);
            }
            else
            {
                mitgliedsanforderungAnbieter.UpdatedAt = DateTime.Now;
                mitgliedsanforderungAnbieter.UpdatedBy = pendenz.UpdatedBy;
                mitgliedsanforderungAnbieter.GueltigBis = gueltigBis;
                db.MitgliedsanforderungAnbieter.Update(mitgliedsanforderungAnbieter);
            }
        }
    }
}
