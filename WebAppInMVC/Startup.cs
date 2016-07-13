using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppInMVC.Startup))]
namespace WebAppInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
