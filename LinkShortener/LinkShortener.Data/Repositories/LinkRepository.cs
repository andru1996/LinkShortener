using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.Data.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        public Link AddLink(Link model)
        {
            throw new NotImplementedException();
        }

        public void DeleteLink(long id)
        {
            throw new NotImplementedException();
        }

        public Link[] GetLinksByCreatorId(Guid creatorId)
        {
            throw new NotImplementedException();
        }

        public Link UpdateLink(Link model)
        {
            throw new NotImplementedException();
        }
    }
}
