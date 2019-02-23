using LinkShortener.Db.Configurations;
using LinkShortener.DbCommon.Models;
using System.Data.Entity;

namespace LinkShortener.Db
{
    public class LinkShortenerDbContext : DbContext
    {
        public LinkShortenerDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public LinkShortenerDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<LinkEntity> Links { get; set; }

        public DbSet<LinkClickEntity> LinkClicks { get; set; }

        public DbSet<UserBlockedStatusEntity> UserBlockedStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LinkConfiguration());
            modelBuilder.Configurations.Add(new LinkClickConfiguration());
            modelBuilder.Configurations.Add(new UserBlockedStatusConfiguration());
        }
    }
}
