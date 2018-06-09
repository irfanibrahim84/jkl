using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jkl.Startup))]
namespace jkl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
