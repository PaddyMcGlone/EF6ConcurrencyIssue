using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF6Concurrency.Startup))]
namespace EF6Concurrency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
