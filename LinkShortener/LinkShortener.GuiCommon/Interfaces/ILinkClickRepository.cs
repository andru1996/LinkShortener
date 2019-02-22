using LinkShortener.GuiCommon.Models;

namespace LinkShortener.GuiCommon.Interfaces
{
    public interface ILinkClickRepository
    {
        LinkClick[] GetLinkClicksByLinkId(long linkId);

        void AddLinkClick(LinkClick model);
    }
}