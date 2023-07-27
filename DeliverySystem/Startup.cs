using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeliverySystem.Startup))]
namespace DeliverySystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
