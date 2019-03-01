using LinkShortener.DbCommon.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace LinkShortener.Db.Repositories
{
    public static class DbLinkRepository
    {
        public static LinkEntity[] GetLinksByCreatorId(Guid creatorId)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                return db.Links.Where(x => x.CreatorId == creatorId).ToArray();
            }
        }

        public static LinkEntity[] GetAllLinks()
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                return db.Links.ToArray();
            }
        }

        public static LinkEntity GetLink(long id)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                return db.Links.FirstOrDefault(x => x.Id == id);
            }
        }
        
        public static LinkEntity GetLinkByStringId(string stringId)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                return db.Links.FirstOrDefault(x => x.StringId == stringId);
            }
        }

        public static LinkEntity AddLink(LinkEntity model)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                model.PublishedAt = DateTimeOffset.Now;
                db.Links.Add(model);
                db.SaveChanges();
                return model;
            }
        }

        public static LinkEntity UpdateLink(LinkEntity model)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                if (!(db.Links.Find(model.Id) is LinkEntity dbModel))
                {
                    return null;
                }

                dbModel.StringId = model.StringId ?? dbModel.StringId;
                dbModel.Url = model.Url;
                dbModel.Status = model.Status;
                dbModel.UpdateAt = DateTimeOffset.Now;
                db.Entry(dbModel).State = EntityState.Modified;
                db.SaveChanges();
                return dbModel;
            }
        }

        public static void DeleteLink(long id)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                var model = db.Links.Find(id);
                db.Links.Remove(model);
                db.SaveChanges();
            }
        }

        
    }
}
