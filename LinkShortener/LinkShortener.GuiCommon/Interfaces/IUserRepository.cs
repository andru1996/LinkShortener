using LinkShortener.GuiCommon.Models;
using System;

namespace LinkShortener.GuiCommon.Interfaces
{
    public interface IUserRepository
    {
        UserBlockedStatus[] GeAllUserBlockedStatuses();

        UserBlockedStatus AddUserBlockedStatus(Guid userId);

        void  DeleteUserBlockedStatus(Guid userId);
    }
}
