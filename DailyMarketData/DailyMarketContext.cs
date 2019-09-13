using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DailyMarketData.Models;

namespace DailyMarketData
{
    public partial class DailyMarketContext : DbContext
    {
        public DailyMarketContext()
        {
        }

        public DailyMarketContext(DbContextOptions<DailyMarketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anbieter> Anbieter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anbieter>(entity =>
            {
                entity.Property(e => e.Nachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
