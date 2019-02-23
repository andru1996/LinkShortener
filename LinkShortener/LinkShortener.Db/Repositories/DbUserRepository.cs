using LinkShortener.DbCommon.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace LinkShortener.Db.Repositories
{
    public static class DbUserRepository
    {
        public static UserBlockedStatusEntity[] GeAllUserBlockedStatuses()
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                return db.UserBlockedStatuses.ToArray();
            }
        }

        public static UserBlockedStatusEntity AddUserBlockedStatus(Guid userId)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                var model = new UserBlockedStatusEntity
                {
                    UserId = userId,
                    PublishedAt = DateTimeOffset.Now,
                };
                db.UserBlockedStatuses.Add(model);                
                db.SaveChanges();
                return model;
            }
        }

        public static void DeleteUserBlockedStatus(Guid userId)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                var model = db.UserBlockedStatuses.FirstOrDefault(x => x.UserId == userId);
                db.UserBlockedStatuses.Remove(model);
                db.SaveChanges();
            }
        }
    }
}
