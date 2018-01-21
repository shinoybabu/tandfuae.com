using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tandfuae.Startup))]
namespace tandfuae
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
