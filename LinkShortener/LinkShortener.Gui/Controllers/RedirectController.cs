using LinkShortener.Data;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;
using System.Web.Mvc;

namespace LinkShortener.Gui.Controllers
{
    public class RedirectController : Controller
    {
        ILinkRepository _linkRepository = RepositoriesFactory.GetLinkRepository();
        ILinkClickRepository _linkClickRepository = RepositoriesFactory.GetLinkClickRepository();

        [HttpGet]
        [Route("~/{stringId}")]
        public RedirectResult RedirectToLinkUrlByStringId(string stringId)
        {
            if (_linkRepository.GetLinkByStringId(stringId) is Link link)
            {
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
    }
}