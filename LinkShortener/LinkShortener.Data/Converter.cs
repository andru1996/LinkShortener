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
    }
}
