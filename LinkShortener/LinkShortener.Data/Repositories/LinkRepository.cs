using LinkShortener.Db.Repositories;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;
using System.Collections.Generic;
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

        public LinkWithClicksCount[] GetLinksWithClicksByCreatorId(Guid creatorId)
        {
            var linkClicksRepository = new LinkClickRepository();
            var models = GetLinksByCreatorId(creatorId);
            List<LinkWithClicksCount> result = new List<LinkWithClicksCount>();
            foreach (var model in models)
            {
                var item = new LinkWithClicksCount(model);
                item.ClicksCount = linkClicksRepository.GetLinkClicksCountByLinkId(model.Id);
                result.Add(item);
            }
            return result.ToArray();
        }

        public Link GetLink(long id)
        {
            return Converter.ConvertToGuiModel(DbLinkRepository.GetLink(id));
        }

        public Link GetLinkByStringId(string stringId)
        {
            return Converter.ConvertToGuiModel(DbLinkRepository.GetLinkByStringId(stringId));
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
    }
}
