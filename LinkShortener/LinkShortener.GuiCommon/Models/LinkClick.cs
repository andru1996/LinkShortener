using System;
using System.ComponentModel.DataAnnotations;

namespace LinkShortener.GuiCommon.Models
{
    public class LinkClick
    {
        public long LinkId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTimeOffset PublishedAt { get; set; }
    }
}
