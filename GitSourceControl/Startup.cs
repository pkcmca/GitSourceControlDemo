using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitSourceControl.Startup))]
namespace GitSourceControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
