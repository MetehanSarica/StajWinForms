using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StajWinForms_API.Models;

public partial class DbStajContext : DbContext
{
    public DbStajContext()
    {
    }

    public DbStajContext(DbContextOptions<DbStajContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Biletler> Biletlers { get; set; }

    public virtual DbSet<Firmalar> Firmalars { get; set; }

    public virtual DbSet<Musteri> Musteris { get; set; }

    public virtual DbSet<Otogarlar> Otogarlars { get; set; }

    public virtual DbSet<Personel> Personels { get; set; }

    public virtual DbSet<SeferDuraklar> SeferDuraklars { get; set; }

    public virtual DbSet<SeferDurakOtogar> SeferDurakOtogars { get; set; }

    public virtual DbSet<SeferPersonel> SeferPersonels { get; set; }

    public virtual DbSet<Seferler> Seferlers { get; set; }

    public virtual DbSet<Sehirler> Sehirlers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Biletler>(entity =>
        {
            entity.HasKey(e => e.BiletId).HasName("PK__Biletler__9518DFE969FC4467");

            entity.ToTable("Biletler");

            entity.Property(e => e.BiletId).HasColumnName("BiletID");
            entity.Property(e => e.Cinsiyet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.Property(e => e.MusteriTc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MusteriTC");
            entity.Property(e => e.SeferId).HasColumnName("SeferID");

            entity.HasOne(d => d.MusteriTcNavigation).WithMany(p => p.Biletlers)
                .HasPrincipalKey(p => p.Tc)
                .HasForeignKey(d => d.MusteriTc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Biletler__Muster__1BC821DD");

            entity.HasOne(d => d.Sefer).WithMany(p => p.Biletlers)
                .HasForeignKey(d => d.SeferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Biletler__SeferI__1AD3FDA4");
        });

        modelBuilder.Entity<Firmalar>(entity =>
        {
            entity.HasKey(e => e.FirmaId).HasName("PK__Firmalar__CD9C5ECFD05DDE10");

            entity.ToTable("Firmalar");

            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.FirmaAdi).HasMaxLength(100);
        });

        modelBuilder.Entity<Musteri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Musteri__3214EC07A17CC9BD");

            entity.ToTable("Musteri");

            entity.HasIndex(e => e.Tc, "UQ__Musteri__3214E409260391D0").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Musteri__A9D105345D3AC0CB").IsUnique();

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.Adres).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.KayitTarihi).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Sehir).HasMaxLength(50);
            entity.Property(e => e.Soyad).HasMaxLength(50);
            entity.Property(e => e.Tc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TC");
            entity.Property(e => e.Telefon).HasMaxLength(20);
        });

        modelBuilder.Entity<Personel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personel__3214EC072D11104B");

            entity.ToTable("Personel");

            entity.HasIndex(e => e.Email, "UQ__Personel__A9D105349D54E10F").IsUnique();

            entity.Property(e => e.Ad).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.IseGirisTarihi).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Maas).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Soyad).HasMaxLength(50);
        });

        modelBuilder.Entity<SeferDuraklar>(entity =>
        {
            entity.HasKey(e => new { e.SeferId, e.DurakSira }).HasName("PK__SeferDur__DDA3F5231E023999");

            entity.ToTable("SeferDuraklar");

            entity.Property(e => e.SeferId).HasColumnName("SeferID");
            entity.Property(e => e.GelisSaati).HasColumnType("datetime");
            entity.Property(e => e.SehirId).HasColumnName("SehirID");

            entity.HasOne(d => d.Sefer).WithMany(p => p.SeferDuraklars)
                .HasForeignKey(d => d.SeferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeferDura__Sefer__17036CC0");

            entity.HasOne(d => d.Sehir).WithMany(p => p.SeferDuraklars)
                .HasForeignKey(d => d.SehirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeferDura__Sehir__17F790F9");
        });

        modelBuilder.Entity<SeferPersonel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SeferPersonel__ID");

            entity.ToTable("SeferPersonel");

            entity.Property(e => e.SeferId).HasColumnName("SeferID");
            entity.Property(e => e.PersonelId).HasColumnName("PersonelID");
            entity.Property(e => e.Rol).HasMaxLength(50);

            entity.HasOne(d => d.Sefer).WithMany(p => p.SeferPersonels)
                .HasForeignKey(d => d.SeferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeferPersonel__Sefer");

            entity.HasOne(d => d.Personel).WithMany(p => p.SeferPersonels)
                .HasForeignKey(d => d.PersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeferPersonel__Personel");
        });

        modelBuilder.Entity<Seferler>(entity =>
        {
            entity.HasKey(e => e.SeferId).HasName("PK__Seferler__B989AA11011CA8E5");

            entity.ToTable("Seferler");

            entity.Property(e => e.SeferId).HasColumnName("SeferID");
            entity.Property(e => e.FirmaId).HasColumnName("FirmaID");
            entity.Property(e => e.Fiyat).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.KalkisSehirId).HasColumnName("KalkisSehirID");
            entity.Property(e => e.KoltukKapasitesi).HasDefaultValue(36);
            entity.Property(e => e.VarisSehirId).HasColumnName("VarisSehirID");
            entity.Ignore(e => e.BosKoltuk);

            entity.HasOne(d => d.Firma).WithMany(p => p.Seferlers)
                .HasForeignKey(d => d.FirmaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Seferler__FirmaI__6FE99F9F");

            entity.HasOne(d => d.KalkisSehir).WithMany(p => p.SeferlerKalkisSehirs)
                .HasForeignKey(d => d.KalkisSehirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Seferler__Kalkis__70DDC3D8");

            entity.HasOne(d => d.VarisSehir).WithMany(p => p.SeferlerVarisSehirs)
                .HasForeignKey(d => d.VarisSehirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Seferler__VarisS__71D1E811");
        });

        modelBuilder.Entity<Otogarlar>(entity =>
        {
            entity.HasKey(e => e.OtogarId).HasName("PK__Otogarlar__OtogarID");

            entity.ToTable("Otogarlar");

            entity.Property(e => e.OtogarId).HasColumnName("OtogarID");
            entity.Property(e => e.SehirId).HasColumnName("SehirID");
            entity.Property(e => e.OtogarAdi).HasMaxLength(100);
            entity.Property(e => e.Adres).HasMaxLength(250);
            entity.Property(e => e.Telefon).HasMaxLength(20);

            entity.HasOne(d => d.Sehir).WithMany(p => p.Otogarlars)
                .HasForeignKey(d => d.SehirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Otogarlar__Sehir");
        });

        modelBuilder.Entity<SeferDurakOtogar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SeferDurakOtogar__ID");

            entity.ToTable("SeferDurakOtogar");

            entity.Property(e => e.SeferId).HasColumnName("SeferID");
            entity.Property(e => e.OtogarId).HasColumnName("OtogarID");
            entity.Property(e => e.GelisSaati).HasColumnType("datetime");
            entity.Property(e => e.GidisSaati).HasColumnType("datetime");

            entity.HasOne(d => d.Sefer).WithMany(p => p.SeferDurakOtogars)
                .HasForeignKey(d => d.SeferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeferDurakOtogar__Sefer");

            entity.HasOne(d => d.Otogar).WithMany(p => p.SeferDurakOtogars)
                .HasForeignKey(d => d.OtogarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeferDurakOtogar__Otogar");
        });

        modelBuilder.Entity<Sehirler>(entity =>
        {
            entity.HasKey(e => e.SehirId).HasName("PK__Sehirler__D1E8748B842D0CF2");

            entity.ToTable("Sehirler");

            entity.HasIndex(e => e.PlakaKodu, "UQ__Sehirler__40B285F140ED4F40").IsUnique();

            entity.Property(e => e.SehirId).HasColumnName("SehirID");
            entity.Property(e => e.SehirAdi).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
