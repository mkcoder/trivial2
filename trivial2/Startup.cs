using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trivial2.Startup))]
namespace trivial2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
