using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItourOperators.Startup))]
namespace ItourOperators
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
