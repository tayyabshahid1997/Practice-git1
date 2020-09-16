using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewREpossitory.Startup))]
namespace NewREpossitory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
