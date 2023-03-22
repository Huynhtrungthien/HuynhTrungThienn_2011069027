using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhTrungThienn_2011069027.Startup))]
namespace HuynhTrungThienn_2011069027
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
