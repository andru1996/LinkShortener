using LinkShortener.Db.Repositories;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.Data.Repositories
{
    public class LinkClickRepository : ILinkClickRepository
    {
        public void AddLinkClick(LinkClick model)
        {
            var dbModel = Converter.ConvertToDbModel(model);
            DbLinkClickRepository.AddLinkClick(dbModel);
        }

        public LinkClick[] GetLinkClicksByLinkId(long linkId)
        {
            throw new NotImplementedException();
        }
    }
}
