using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StateManagementMVC.Startup))]
namespace StateManagementMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
