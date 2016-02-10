using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gCrawler.Startup))]
namespace gCrawler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
