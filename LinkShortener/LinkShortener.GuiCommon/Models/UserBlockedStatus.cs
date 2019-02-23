using System;

namespace LinkShortener.GuiCommon.Models
{
    public class UserBlockedStatus
    {
        public long Id { get; set; }

        public Guid UserId { get; set; }

        public DateTimeOffset PublishedAt { get; set; }
    }
}