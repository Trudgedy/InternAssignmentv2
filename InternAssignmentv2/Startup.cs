using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternAssignmentv2.Startup))]
namespace InternAssignmentv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
