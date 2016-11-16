using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApi2Application.Startup))]
namespace WebApi2Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
