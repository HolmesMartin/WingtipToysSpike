using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingtipToysSpike.Startup))]
namespace WingtipToysSpike
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
