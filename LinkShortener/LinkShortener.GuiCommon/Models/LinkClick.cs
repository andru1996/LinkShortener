using System;

namespace LinkShortener.GuiCommon.Models
{
    public class LinkClick
    {
        public long Id { get; set; }

        public long LinkId { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}
