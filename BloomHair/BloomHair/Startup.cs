using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloomHair.Startup))]
namespace BloomHair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
