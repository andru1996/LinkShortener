using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.GuiCommon.Interfaces
{
    interface ILinkRepository
    {
        Link[] GetLinksByCreatorId(Guid creatorId);

        Link AddLink(Link model);

        Link UpdateLink(Link model);

        void DeleteLink(long id);
    }
}
