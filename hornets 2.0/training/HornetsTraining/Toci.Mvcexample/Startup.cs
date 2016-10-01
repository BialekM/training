using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Toci.Mvcexample.Startup))]
namespace Toci.Mvcexample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
