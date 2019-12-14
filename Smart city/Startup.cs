using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smart_city.Startup))]
namespace Smart_city
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
