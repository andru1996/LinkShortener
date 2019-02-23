using LinkShortener.DbCommon.Models;
using System.Data.Entity.ModelConfiguration;

namespace LinkShortener.Db.Configurations
{
    internal class UserBlockedStatusConfiguration : EntityTypeConfiguration<UserBlockedStatusEntity>
    {
        public UserBlockedStatusConfiguration()
        {
            ToTable("UserBlockedStatuses");
            HasKey(x => x.Id);
            Property(x => x.UserId).IsRequired();
            Property(x => x.PublishedAt).IsRequired();
        }
    }
}
