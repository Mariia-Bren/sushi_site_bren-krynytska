using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sushi_site_work.Startup))]
namespace sushi_site_work
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
