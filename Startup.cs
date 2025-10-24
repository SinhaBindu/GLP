using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Glass.Startup))]
namespace Glass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
