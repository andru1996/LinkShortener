using LinkShortener.Common.Enums;
using System;

namespace LinkShortener.GuiCommon.Models
{
    public class LinkWithClicksCount : Link
    {
        public long ClicksCount { get; set; }

        public LinkWithClicksCount(Link model)
        {
            Id = model.Id;
            StringId = model.StringId;
            Url = model.Url;
            CreatorId = model.CreatorId;
            Status = model.Status;
            PublishedAt = model.PublishedAt;
            UpdateAt = model.UpdateAt;
        }
    }
}
