using LinkShortener.Db.Repositories;
using LinkShortener.DbCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DbLinkRepository.AddLink(new LinkEntity()
            {                
                StringId = "aaaa",
                Url = "http:\\ya.ru",
                Status = Common.Enums.LinkStatus.SwitchedOn,
                CreatorId = Guid.Empty,
                PublishedAt = DateTimeOffset.Now,
                UpdateAt = DateTimeOffset.Now,
            });
        }
    }
}
