using System;

namespace LinkShortener.DbCommon.Models
{
    public class UserBlockedStatusEntity
    {
        public long Id { get; set; }

        public Guid UserId { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}