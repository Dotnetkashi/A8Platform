using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A8DashBoard.Web.Startup))]
namespace A8DashBoard.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
