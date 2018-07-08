using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC0704.Startup))]
namespace MVC0704
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
