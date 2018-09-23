using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPGManagerWeb.Startup))]
namespace RPGManagerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
