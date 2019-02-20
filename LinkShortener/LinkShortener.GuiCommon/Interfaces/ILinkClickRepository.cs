using LinkShortener.GuiCommon.Models;

namespace LinkShortener.GuiCommon.Interfaces
{
    interface ILinkClickRepository
    {
        LinkClick[] GetLinkClicksByLinkId(long linkId);

        void AddLinkClick(LinkClick model);
    }
}
