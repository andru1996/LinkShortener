using LinkShortener.Data;
using LinkShortener.Gui.Models;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkShortener.Gui.Controllers
{
    [RoutePrefix("Users")]
    public class UsersController : Controller
    {
        IUserRepository _userRepository = RepositoriesFactory.GetUserRepository();

        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            var allUsers = context.Users.ToList();
            var allUserBlockedStatuses = _userRepository.GeAllUserBlockedStatuses();
            var usersWithActiveStatuses = new List<UserWithActiveStatus>();
            foreach (var user in allUsers)
            {
                var blockedStatus = allUserBlockedStatuses.FirstOrDefault(x => x.UserId == new Guid(user.Id));
                var userWithActiveStatus = new UserWithActiveStatus
                {
                    Id = new Guid(user.Id),
                    UserName = user.UserName,
                    Email = user.Email,
                    IsActive = blockedStatus != null,
                    BlockedStatusAt = blockedStatus?.PublishedAt,
                };
                usersWithActiveStatuses.Add(userWithActiveStatus);
            }
            return View(usersWithActiveStatuses.ToArray());
        }

        [Route("ChangeActiveStatus")]
        public ActionResult ChangeActiveStatus(Guid userId, bool isActiveStatus)
        {
            if (isActiveStatus)
            {
                _userRepository.DeleteUserBlockedStatus(userId);
            }
            else
            {
                _userRepository.AddUserBlockedStatus(userId);
            }
            return RedirectToAction("Index", "Users");
        }
    }
}