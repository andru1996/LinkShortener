using LinkShortener.Data.Repositories;
using LinkShortener.GuiCommon.Interfaces;

namespace LinkShortener.Data
{
    public static class RepositoriesFactory
    {
        public static ILinkRepository GetLinkRepository()
        {
            return new LinkRepository();
        }

        public static ILinkClickRepository GetLinkClickRepository()
        {
            return new LinkClickRepository();
        }

        public static IUserRepository GetUserRepository()
        {
            return new UserRepository();
        }
    }
}
