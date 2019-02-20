using LinkShortener.Common.Enums;
using System;

namespace LinkShortener.DbCommon.Models
{
    public class Link : EntityBase
    {
        public string StringId { get; set; }

        public Guid CreatorId { get; set; }

        public LinkStatus Status { get; set; }

        public DateTimeOffset PublishedAt { get; set; }

        public DateTimeOffset UpdateAt { get; set; }
    }
}
