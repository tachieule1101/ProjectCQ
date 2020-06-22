using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebReport1.Startup))]
namespace WebReport1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
