using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Net_ListMod.Startup))]
namespace ASP_Net_ListMod
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
