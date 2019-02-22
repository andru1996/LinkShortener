using LinkShortener.DbCommon.Models;
using System.Linq;

namespace LinkShortener.Db.Repositories
{
    public static class DbLinkClickRepository
    {
        public static LinkClickEntity AddLinkClick(LinkClickEntity model)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                model.Link = db.Links.Find(model.Link.Id);
                db.LinkClicks.Add(model);
                db.SaveChanges();
                return model;
            }
        }

        public static long GetLinkClicksCountByLinkId(long linkId)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {                 
                return db.LinkClicks.Where(x => x.Link.Id == linkId).Count();
            }
        }
    }
}
