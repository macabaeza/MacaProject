using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MacaProject1UI.Startup))]
namespace MacaProject1UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
