using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.GuiCommon.Interfaces
{
    public interface ILinkRepository
    {
        Link[] GetLinksByCreatorId(Guid creatorId);

        Link[] GetAllLinks();

        LinkWithClicksCount[] GetLinksWithClicksByCreatorId(Guid creatorId);

        LinkWithClicksCount[] GetAllLinksWithClicks();

        Link GetLink(long id);

        Link GetLinkByStringId(string stringId);

        Link AddLink(Link model);

        Link UpdateLink(Link model);

        void DeleteLink(long id);
    }
}
