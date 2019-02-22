using LinkShortener.DbCommon.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace LinkShortener.Db.Repositories
{
    public static class DbLinkClickRepository
    {
        public static LinkClickEntity AddLinkClick(LinkClickEntity model)
        {
            using (LinkShortenerDbContext db = new LinkShortenerDbContext())
            {
                db.LinkClicks.Add(model);
                db.SaveChanges();
                return model;
            }
        }
    }
}
