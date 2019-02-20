using LinkShortener.DbCommon.Models;
using System.Data.Entity.ModelConfiguration;

namespace LinkShortener.Db.Configurations
{
    internal class LinkClickConfiguration : EntityTypeConfiguration<LinkClick>
    {
        public LinkClickConfiguration()
        {
            ToTable("LinkClicks");
            HasKey(x => x.Id);
            HasRequired(x => x.Link);
            Property(x => x.PublishedAt).IsRequired();
        }
    }
}
