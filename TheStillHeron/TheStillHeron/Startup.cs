using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheStillHeron.Startup))]
namespace TheStillHeron
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
