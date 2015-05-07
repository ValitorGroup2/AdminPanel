using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VasinnAdminPanel.Startup))]
namespace VasinnAdminPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
