using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ono.Startup))]
namespace Ono
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
