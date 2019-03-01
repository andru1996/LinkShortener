using LinkShortener.Common.Enums;
using System;

namespace LinkShortener.GuiCommon.Models
{
    public class LinkWithUserEmailAndClicksCount : LinkWithClicksCount
    {
        public string UserEmail { get; set; }

        public LinkWithUserEmailAndClicksCount(Link model) : base(model)
        {
            Id = model.Id;
            StringId = model.StringId;
            Url = model.Url;
            CreatorId = model.CreatorId;
            Status = model.Status;
            PublishedAt = model.PublishedAt;
            UpdateAt = model.UpdateAt;
            //ClicksCount = model.ClicksCount;
        }
    }
}
