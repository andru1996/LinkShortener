using LinkShortener.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace LinkShortener.GuiCommon.Models
{
    public class Link
    {
        public long Id { get; set; }

        public string StringId { get; set; }

        public string Url { get; set; }

        public Guid CreatorId { get; set; }

        public LinkStatus Status { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTimeOffset PublishedAt { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTimeOffset UpdateAt { get; set; }
    }
}
