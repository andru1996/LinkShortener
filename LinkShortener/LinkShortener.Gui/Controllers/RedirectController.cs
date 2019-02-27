using LinkShortener.Common.Enums;
using LinkShortener.Data;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace LinkShortener.Gui.Controllers
{
    [RoutePrefix("Redirect")]
    public class RedirectController : Controller
    {
        private readonly ILinkRepository _linkRepository = RepositoriesFactory.GetLinkRepository();
        private readonly ILinkClickRepository _linkClickRepository = RepositoriesFactory.GetLinkClickRepository();
        private readonly IUserRepository _userRepository = RepositoriesFactory.GetUserRepository();

        [HttpGet]
        [Route("~/{stringId}")]
        public RedirectResult RedirectToLinkUrlByStringId(string stringId)


        {
            if (_linkRepository.GetLinkByStringId(stringId) is Link link)
            {
                if (link.Status != LinkStatus.SwitchedOn)
                {
                    return Redirect("Redirect/Error");
                }

                var userBlockedStatuses = _userRepository.GeAllUserBlockedStatuses();
                if (userBlockedStatuses.Any(x=>x.UserId == link.CreatorId))
                {
                    return Redirect("Redirect/Error");
                }

                _linkClickRepository.AddLinkClick(new LinkClick()
                {
                    LinkId = link.Id,
                    PublishedAt = DateTimeOffset.Now,
                });
                return Redirect(link.Url);
            }
            else
            {
                return Redirect("Home/Index");
            }
        }

        [AllowAnonymous]
        [Route("Error")]
        public ActionResult Error()
        {
            return View();
        }
    }
}