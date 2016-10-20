using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alanda.Startup))]
namespace Alanda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
