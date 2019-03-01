using System;
using System.ComponentModel.DataAnnotations;

namespace LinkShortener.GuiCommon.Models
{
    public class UserBlockedStatus
    {
        public long Id { get; set; }

        public Guid UserId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTimeOffset PublishedAt { get; set; }
    }
}