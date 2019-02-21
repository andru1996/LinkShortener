using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkShortener.Startup))]
namespace LinkShortener
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
