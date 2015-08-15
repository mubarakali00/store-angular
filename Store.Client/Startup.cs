using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store.Client.Startup))]
namespace Store.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
