using LinkShortener.GuiCommon.Models;

namespace LinkShortener.GuiCommon.Interfaces
{
    public interface ILinkClickRepository
    {
        long GetLinkClicksCountByLinkId(long linkId);

        void AddLinkClick(LinkClick model);
    }
}