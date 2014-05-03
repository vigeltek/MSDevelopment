using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrypTick.Startup))]
namespace CrypTick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
