using LinkShortener.DbCommon.Models;
using System.Data.Entity.ModelConfiguration;

namespace LinkShortener.Db.Configurations
{
    internal class LinkConfiguration : EntityTypeConfiguration<Link>
    {
        public LinkConfiguration()
        {
            ToTable("Links");
            HasKey(x => x.Id);
            Property(x => x.StringId).IsRequired();
            Property(x => x.CreatorId).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.PublishedAt).IsRequired();
            Property(x => x.UpdateAt).IsRequired();
        }
    }
}
