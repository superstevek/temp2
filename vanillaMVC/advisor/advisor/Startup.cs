using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(advisor.Startup))]
namespace advisor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
