using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamCatApp.Startup))]
namespace TeamCatApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
