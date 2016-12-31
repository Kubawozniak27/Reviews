using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projektKompo.Startup))]
namespace projektKompo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
