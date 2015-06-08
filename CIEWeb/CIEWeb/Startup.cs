using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIEWeb.Startup))]
namespace CIEWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
