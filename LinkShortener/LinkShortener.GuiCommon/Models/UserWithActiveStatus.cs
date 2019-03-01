using System;
using System.ComponentModel.DataAnnotations;

namespace LinkShortener.GuiCommon.Models
{
    public class UserWithActiveStatus
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTimeOffset? BlockedStatusAt { get; set; }
    }
}