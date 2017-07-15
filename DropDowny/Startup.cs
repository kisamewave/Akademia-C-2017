using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropDowny.Startup))]
namespace DropDowny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
