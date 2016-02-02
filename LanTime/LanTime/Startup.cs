using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanTime.Startup))]
namespace LanTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
