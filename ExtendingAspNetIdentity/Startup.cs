using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExtendingAspNetIdentity.Startup))]
namespace ExtendingAspNetIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
