using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sushi_site_c.Startup))]
namespace sushi_site_c
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
