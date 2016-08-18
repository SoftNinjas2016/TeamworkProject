using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Blog_ALV.Startup))]
namespace MVC_Blog_ALV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
