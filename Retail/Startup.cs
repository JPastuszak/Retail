using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Retail.Startup))]
namespace Retail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
