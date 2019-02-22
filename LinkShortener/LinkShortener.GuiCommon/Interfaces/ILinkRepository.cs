using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.GuiCommon.Interfaces
{
    public interface ILinkRepository
    {
        Link[] GetLinksByCreatorId(Guid creatorId);

        LinkWithClicksCount[] GetLinksWithClicksByCreatorId(Guid creatorId);

        Link GetLink(long id);

        Link GetLinkByStringId(string stringId);

        Link AddLink(Link model);

        Link UpdateLink(Link model);

        void DeleteLink(long id);
    }
}
