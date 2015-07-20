using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cas_GSB.Startup))]
namespace Cas_GSB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
