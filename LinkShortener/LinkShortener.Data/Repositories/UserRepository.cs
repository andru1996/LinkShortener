using LinkShortener.Db.Repositories;
using LinkShortener.GuiCommon.Interfaces;
using LinkShortener.GuiCommon.Models;
using System;
using System.Linq;

namespace LinkShortener.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserBlockedStatus[] GeAllUserBlockedStatuses()
        {
            var models = DbUserRepository.GeAllUserBlockedStatuses();
            return models.Select(Converter.ConvertToGuiModel).ToArray();
        }

        public UserBlockedStatus AddUserBlockedStatus(Guid userId)
        {
            return Converter.ConvertToGuiModel(
                DbUserRepository.AddUserBlockedStatus(userId));
        }

        public void DeleteUserBlockedStatus(Guid userId)
        {
            DbUserRepository.DeleteUserBlockedStatus(userId);
        }
    }
}
