using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenDucManh_1911061942.Startup))]
namespace NguyenDucManh_1911061942
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
