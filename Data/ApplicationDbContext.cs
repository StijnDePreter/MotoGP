using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MotoGP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoGP.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        //alles hieronder is zelf toegevoegd
        public DbSet<Race> Races { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Rider>().ToTable("Rider");
            modelBuilder.Entity<Team>().ToTable("Team");
        }

        //alles hierboven is zelf toegevoegd


    }
}
