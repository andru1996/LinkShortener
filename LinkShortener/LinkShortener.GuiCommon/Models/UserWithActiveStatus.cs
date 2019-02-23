using System;

namespace LinkShortener.GuiCommon.Models
{
    public class UserWithActiveStatus
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }        

        public DateTimeOffset? BlockedStatusAt { get; set; }
    }
}