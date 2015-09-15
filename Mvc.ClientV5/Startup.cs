using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc.ClientV5.Startup))]
namespace Mvc.ClientV5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
