using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using src.Domain;

namespace src.EF
{
    public class MyDbContext : DbContext
    {
      
        public virtual DbSet<Config> Config {get; set;}
        

        public virtual DbSet<PhotoAnnouncement> Photos { get; protected set; }
        public virtual DbSet<PriceDetailsAnnouncement> PriceDetails {get; protected set; } 
        public virtual DbSet<Announcement> Announcements {get; protected set; } 

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PriceDetailsAnnouncement>(entity =>
            {
                entity.HasNoKey();
            });
        }
    }
}