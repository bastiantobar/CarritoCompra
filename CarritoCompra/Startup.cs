using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarritoCompra.Startup))]
namespace CarritoCompra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
