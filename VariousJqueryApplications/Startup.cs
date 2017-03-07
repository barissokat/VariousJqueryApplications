using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VariousJqueryApplications.Startup))]
namespace VariousJqueryApplications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
