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
            : base()
        {
        }

        public DbSet<Link> Links { get; set; }

        public DbSet<Link> LinkClicks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LinkConfiguration());
            modelBuilder.Configurations.Add(new LinkClickConfiguration());
        }
    }
}
