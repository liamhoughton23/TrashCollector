using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashWebsite.Startup))]
namespace TrashWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
