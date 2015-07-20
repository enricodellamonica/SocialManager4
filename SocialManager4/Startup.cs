using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialManager4.Startup))]
namespace SocialManager4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
