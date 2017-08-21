using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BB.Startup))]
namespace BB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
