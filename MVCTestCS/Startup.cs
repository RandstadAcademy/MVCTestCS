using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTestCS.Startup))]
namespace MVCTestCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
