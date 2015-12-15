using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuTor.Startup))]
namespace TuTor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
