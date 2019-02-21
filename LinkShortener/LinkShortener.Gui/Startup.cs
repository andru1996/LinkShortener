using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkShortener.Gui.Startup))]
namespace LinkShortener.Gui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
