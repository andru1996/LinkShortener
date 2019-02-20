using LinkShortener.Common.Enums;
using System;

namespace LinkShortener.GuiCommon.Models
{
    public class Link
    {
        public long Id { get; set; }

        public long StringId { get; set; }

        public Guid CreatorId { get; set; }

        public LinkStatus Status { get; set; }

        public DateTimeOffset PublishedAt { get; set; }

        public DateTimeOffset UpdateAt { get; set; }
    }
}
