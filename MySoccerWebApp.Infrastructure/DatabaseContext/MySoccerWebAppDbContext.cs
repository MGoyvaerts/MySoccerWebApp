using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Interfaces.DatabaseContext;
using MySoccerWebApp.Infrastructure.Migrations;

namespace MySoccerWebApp.Infrastructure.DatabaseContext
{
    public class MySoccerWebAppDbContext : DbContext
    {
        #region Constructors
        public MySoccerWebAppDbContext() : base("MySoccerWebApp")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MySoccerWebAppDbContext, Configuration>());
            Database.SetInitializer(new MySoccerWebAppInitializer());
        }
        #endregion

        #region Database tables
        public DbSet<City> Cities { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Contactperson> ClubContactpersons { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Gameweek> Gameweeks { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region City
            modelBuilder.Entity<City>()
                .HasMany<Club>(c => c.Clubs)
                .WithRequired(c => c.City)
                .WillCascadeOnDelete(false);
            #endregion

            #region Club
            //modelBuilder.Entity<Club>()
            //    .HasMany<Player>(p => p.Players)
            //    .WithRequired(c => c.Club)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Club>()
            //    .HasMany<Gameweek>(g=>g.Gameweeks)
            //    .WithRequired(c => c.AwayTeam)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Club>()
            //    .HasMany<Gameweek>(g => g.Gameweeks)
            //    .WithRequired(c => c.HomeTeam)
            //    .WillCascadeOnDelete(false);
            #endregion

            #region ClubContactperson
            //modelBuilder.Entity<Contactperson>()
            //    .HasRequired(cp => cp.Club)
            //    .WithRequiredPrincipal(c => c.ContactPerson);
            #endregion

            #region Country
            modelBuilder.Entity<Country>()
                .HasMany<Province>(p => p.Provinces)
                .WithRequired(c => c.Country)
                .WillCascadeOnDelete(false);
            #endregion

            #region Devision
            modelBuilder.Entity<Division>()
                .HasMany<Club>(c => c.Clubs)
                .WithRequired(d => d.Division)
                .WillCascadeOnDelete(false);
            #endregion

            #region Gameweek

            #endregion

            #region Player

            #endregion

            #region PlayerPosition
            modelBuilder.Entity<PlayerPosition>()
                .HasMany<Player>(p => p.Players)
                .WithRequired(pp => pp.Position)
                .WillCascadeOnDelete();
            #endregion

            #region Province
            modelBuilder.Entity<Province>()
                .HasMany<City>(c => c.Cities)
                .WithRequired(p => p.Province)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Province>()
                .HasMany<Division>(d => d.Divisions)
                .WithOptional(p => p.Province)
                .WillCascadeOnDelete();
            #endregion

            #region Role
            modelBuilder.Entity<Role>()
                .HasMany<UserRole>(ur => ur.UserRoles)
                .WithOptional(r => r.Role)
                .WillCascadeOnDelete();
            #endregion

            #region Season
            modelBuilder.Entity<Season>()
                .HasMany<Gameweek>(g => g.Gameweeks)
                .WithRequired(s => s.Season)
                .WillCascadeOnDelete();
            #endregion

            #region Trainer
            modelBuilder.Entity<Trainer>()
                .HasRequired(t => t.Club)
                .WithRequiredPrincipal(c => c.Trainer);
            #endregion

            #region User
            modelBuilder.Entity<User>()
                .HasMany<UserRole>(ur => ur.UserRoles)
                .WithOptional(u => u.User)
                .WillCascadeOnDelete();
            #endregion

            #region UserRole

            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
