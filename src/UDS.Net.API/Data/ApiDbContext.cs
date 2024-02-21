using System;
using Microsoft.EntityFrameworkCore;
using UDS.Net.API.Entities;

namespace UDS.Net.API.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Participation> Participations { get; set; }
        public DbSet<M1> M1s { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public DbSet<A1> A1s { get; set; }
        public DbSet<A1a> A1as { get; set; }
        public DbSet<A2> A2s { get; set; }
        public DbSet<A3> A3s { get; set; }
        public DbSet<A4> A4s { get; set; }
        public DbSet<A4a> A4as { get; set; }
        public DbSet<A5D2> A5D2s { get; set; }
        public DbSet<B1> B1s { get; set; }
        public DbSet<B3> B3s { get; set; }
        public DbSet<B4> B4s { get; set; }
        public DbSet<B5> B5s { get; set; }
        public DbSet<B6> B6s { get; set; }
        public DbSet<B7> B7s { get; set; }
        public DbSet<B8> B8s { get; set; }
        public DbSet<B9> B9s { get; set; }
        public DbSet<C1> C1s { get; set; }
        public DbSet<C2> C2s { get; set; }
        public DbSet<D1> D1s { get; set; }
        public DbSet<T1> T1s { get; set; }

        /* Lookup/reference tables */
        public DbSet<DrugCodeLookup> DrugCodesLookup { get; set; }

        /* SQL Views */
        public DbSet<FormStatus> FormStatuses { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* SQL Tables */

            modelBuilder.Entity<A1>(entity =>
            {
                entity.Property(a => a.IsIncluded).IsRequired(true).HasDefaultValue(true);
                entity.Property(a => a.ReasonCode).HasDefaultValue(null);
            });

            modelBuilder.Entity<A4a>(entity =>
            {
                entity.OwnsOne(
                    a => a.Treatment1,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB1");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU1");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF1");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN1");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH1");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX1");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL1");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM1");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO1");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR1");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO1");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR1");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL1");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP1");
                    });

                entity.OwnsOne(
                    a => a.Treatment2,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB2");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU2");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF2");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN2");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH2");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX2");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL2");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM2");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO2");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR2");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO2");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR2");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL2");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP2");
                    });

                entity.OwnsOne(
                    a => a.Treatment3,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB3");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU3");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF3");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN3");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH3");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX3");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL3");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM3");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO3");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR3");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO3");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR3");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL3");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP3");
                    });

                entity.OwnsOne(
                    a => a.Treatment4,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB4");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU4");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF4");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN4");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH4");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX4");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL4");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM4");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO4");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR4");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO4");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR4");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL4");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP4");
                    });

                entity.OwnsOne(
                    a => a.Treatment5,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB5");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU5");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF5");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN5");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH5");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX5");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL5");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM5");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO5");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR5");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO5");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR5");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL5");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP5");
                    });

                entity.OwnsOne(
                    a => a.Treatment6,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB6");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU6");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF6");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN6");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH6");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX6");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL6");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM6");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO6");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR6");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO6");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR6");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL6");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP6");
                    });

                entity.OwnsOne(
                    a => a.Treatment7,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB7");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU7");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF7");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN7");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH7");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX7");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL7");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM7");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO7");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR7");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO7");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR7");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL7");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP7");
                    });

                entity.OwnsOne(
                    a => a.Treatment8,
                    ad =>
                    {
                        ad.Property(p => p.TARGETAB).HasColumnName("TARGETAB8");
                        ad.Property(p => p.TARGETTAU).HasColumnName("TARGETTAU8");
                        ad.Property(p => p.TARGETINF).HasColumnName("TARGETINF8");
                        ad.Property(p => p.TARGETSYN).HasColumnName("TARGETSYN8");
                        ad.Property(p => p.TARGETOTH).HasColumnName("TARGETOTH8");
                        ad.Property(p => p.TARGETOTX).HasColumnName("TARGETOTX8");
                        ad.Property(p => p.TRTTRIAL).HasColumnName("TRTTRIAL8");
                        ad.Property(p => p.NCTNUM).HasColumnName("NCTNUM8");
                        ad.Property(p => p.STARTMO).HasColumnName("STARTMO8");
                        ad.Property(p => p.STARTYEAR).HasColumnName("STARTYEAR8");
                        ad.Property(p => p.ENDMO).HasColumnName("ENDMO8");
                        ad.Property(p => p.ENDYEAR).HasColumnName("ENDYEAR8");
                        ad.Property(p => p.CARETRIAL).HasColumnName("CARETRIAL8");
                        ad.Property(p => p.TRIALGRP).HasColumnName("TRIALGRP8");
                    });
            });

            /* SQL Views */

            modelBuilder.Entity<FormStatus>().ToView("vw_FormStatuses")
                .HasKey(f => new { f.VisitId, f.Kind });


        }
    }
}

