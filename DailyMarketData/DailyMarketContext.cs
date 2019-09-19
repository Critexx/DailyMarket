using System;
using DailyMarketData.Models;
using Microsoft.EntityFrameworkCore;

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

        public virtual DbSet<Abotyp> Abotyp { get; set; }
        public virtual DbSet<Anbieter> Anbieter { get; set; }
        public virtual DbSet<Belegung> Belegung { get; set; }
        public virtual DbSet<Mietvertrag> Mietvertrag { get; set; }
        public virtual DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public virtual DbSet<Mitgliedsanforderung> Mitgliedsanforderung { get; set; }
        public virtual DbSet<MitgliedsanforderungAnbieter> MitgliedsanforderungAnbieter { get; set; }
        public virtual DbSet<Pendenz> Pendenz { get; set; }
        public virtual DbSet<Rapport> Rapport { get; set; }
        public virtual DbSet<Standort> Standort { get; set; }
        public virtual DbSet<Standplatz> Standplatz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abotyp>(entity =>
            {
                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UQ_Abotyp_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.Beschreibung).IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GueltigBis).HasColumnType("date");

                entity.Property(e => e.GueltigVon).HasColumnType("date");

                entity.Property(e => e.RabattInProzent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Anbieter>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Belegung>(entity =>
            {
                entity.HasKey(e => new { e.MietvertragId, e.StandplatzId })
                    .HasName("PK_Belegung_1");

                entity.HasOne(d => d.Mietvertrag)
                    .WithMany(p => p.Belegung)
                    .HasForeignKey(d => d.MietvertragId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Belegung_Mietvertrag");

                entity.HasOne(d => d.Standplatz)
                    .WithMany(p => p.Belegung)
                    .HasForeignKey(d => d.StandplatzId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Belegung_Standplatz");
            });

            modelBuilder.Entity<Mietvertrag>(entity =>
            {
                entity.Property(e => e.Abrechnung).HasColumnType("money");

                entity.Property(e => e.GueltigBis).HasColumnType("date");

                entity.Property(e => e.GueltigVon).HasColumnType("date");

                entity.HasOne(d => d.Abotyp)
                    .WithMany(p => p.Mietvertrag)
                    .HasForeignKey(d => d.AbotypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mietvertrag_Abotyp");

                entity.HasOne(d => d.Anbieter)
                    .WithMany(p => p.Mietvertrag)
                    .HasForeignKey(d => d.AnbieterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mietvertrag_Anbieter");
            });

            modelBuilder.Entity<Mitarbeiter>(entity =>
            {
                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stundensatz).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Vorname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mitgliedsanforderung>(entity =>
            {
                entity.Property(e => e.Beschreibung).IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MitgliedsanforderungAnbieter>(entity =>
            {
                entity.ToTable("Mitgliedsanforderung_Anbieter");

                entity.Property(e => e.GueltigAb).HasColumnType("date");

                entity.Property(e => e.GueltigBis).HasColumnType("date");

                entity.HasOne(d => d.Anbieter)
                    .WithMany(p => p.MitgliedsanforderungAnbieter)
                    .HasForeignKey(d => d.AnbieterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mitgliedsanforderung_Anbieter_Anbieter");

                entity.HasOne(d => d.Mitgliedsanforderung)
                    .WithMany(p => p.MitgliedsanforderungAnbieter)
                    .HasForeignKey(d => d.MitgliedsanforderungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mitgliedsanforderung_Anbieter_Mitgliedsanforderung");
            });

            modelBuilder.Entity<Pendenz>(entity =>
            {
                entity.Property(e => e.Beschreibung).IsUnicode(false);

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Anbieter)
                    .WithMany(p => p.Pendenz)
                    .HasForeignKey(d => d.AnbieterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pendenz_Anbieter");

                entity.HasOne(d => d.Mitgliedsanforderung)
                    .WithMany(p => p.Pendenz)
                    .HasForeignKey(d => d.MitgliedsanforderungId)
                    .HasConstraintName("FK_Pendenz_Mitgliedsanforderung");
            });

            modelBuilder.Entity<Rapport>(entity =>
            {
                entity.Property(e => e.Aufwand).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Beschreibung).IsUnicode(false);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Stundensatz).HasColumnType("decimal(17, 2)");

                entity.HasOne(d => d.Mitarbeiter)
                    .WithMany(p => p.Rapport)
                    .HasForeignKey(d => d.MitarbeiterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rapport_Mitarbeiter");

                entity.HasOne(d => d.Pendenz)
                    .WithMany(p => p.Rapport)
                    .HasForeignKey(d => d.PendenzId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rapport_Pendenz");
            });

            modelBuilder.Entity<Standort>(entity =>
            {
                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ort)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Strasse)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Standplatz>(entity =>
            {
                entity.Property(e => e.PreisProTag).HasColumnType("money");

                entity.HasOne(d => d.Standort)
                    .WithMany(p => p.Standplaetze)
                    .HasForeignKey(d => d.StandortId)
                    .HasConstraintName("FK_Standplatz_Standort");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
