using System;

namespace LinkShortener.DbCommon.Models
{
    public class LinkClickEntity : EntityBase
    {
        public virtual LinkEntity Link { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}
