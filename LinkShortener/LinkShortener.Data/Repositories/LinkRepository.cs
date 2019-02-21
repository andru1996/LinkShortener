using LinkShortener.Db.Repositories;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;
using System.Linq;

namespace LinkShortener.Data.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        public Link[] GetLinksByCreatorId(Guid creatorId)
        {
            var models = DbLinkRepository.GetLinksByCreatorId(creatorId);
            return models.Select(Converter.ConvertToGuiModel).ToArray();
        }

        public Link AddLink(Link model)
        {
            return Converter.ConvertToGuiModel(
                DbLinkRepository.AddLink(
                    Converter.ConvertToDbModel(model)));
        }

        public void DeleteLink(long id)
        {
            DbLinkRepository.DeleteLink(id);
        }        

        public Link UpdateLink(Link model)
        {
            return Converter.ConvertToGuiModel(
                DbLinkRepository.UpdateLink(
                    Converter.ConvertToDbModel(model)));
        }

        public Link GetLink(long id)
        {
            return Converter.ConvertToGuiModel(DbLinkRepository.GetLink(id));
        }
    }
}
