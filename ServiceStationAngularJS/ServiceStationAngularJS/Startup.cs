using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceStationAngularJS.Startup))]
namespace ServiceStationAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
