using LinkShortener.Db.Repositories;
using LinkShortener.DbCommon.Models;
using LinkShortener.GuiCommon.Models;

namespace LinkShortener.Data
{
    public static class Converter
    {
        public static Link ConvertToGuiModel(LinkEntity model)
        {
            return model != null
                ? new Link
                {
                    Id = model.Id,
                    StringId = model.StringId,
                    Url = model.Url,
                    CreatorId = model.CreatorId,
                    Status = model.Status,
                    PublishedAt = model.PublishedAt,
                    UpdateAt = model.UpdateAt,
                }
                : null;
        }

        public static LinkEntity ConvertToDbModel(Link model)
        {
            return model != null
                ? new LinkEntity
                {
                    Id = model.Id,
                    StringId = model.StringId,
                    Url = model.Url,
                    CreatorId = model.CreatorId,
                    Status = model.Status,
                    PublishedAt = model.PublishedAt,
                    UpdateAt = model.UpdateAt,
                }
                : null;
        }

        public static LinkClick ConvertToGuiModel(LinkClickEntity model)
        {
            return model != null
                ? new LinkClick
                {
                    LinkId = model.Link.Id,
                    PublishedAt = model.PublishedAt,
                }
                : null;
        }

        public static LinkClickEntity ConvertToDbModel(LinkClick model)
        {
            return model != null
                ? new LinkClickEntity
                {
                    Link = DbLinkRepository.GetLink(model.LinkId),
                    PublishedAt = model.PublishedAt,
                }
                : null;
        }
    }
}
