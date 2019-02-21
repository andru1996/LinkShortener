using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.GuiCommon.Interfaces
{
    public interface ILinkRepository
    {
        Link[] GetLinksByCreatorId(Guid creatorId);

        Link GetLink(long id);

        Link AddLink(Link model);

        Link UpdateLink(Link model);

        void DeleteLink(long id);
    }
}
