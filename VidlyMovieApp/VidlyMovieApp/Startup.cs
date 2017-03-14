using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMovieApp.Startup))]
namespace VidlyMovieApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
