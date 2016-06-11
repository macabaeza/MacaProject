using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MacaProjectUI.Startup))]
namespace MacaProjectUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
