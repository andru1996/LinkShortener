using System;

namespace LinkShortener.DbCommon.Models
{
    public class LinkClick : EntityBase
    {
        public virtual Link Link { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}
