using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlbumSampler.Startup))]
namespace AlbumSampler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
