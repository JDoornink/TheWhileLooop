using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheWhileLooop.Startup))]
namespace TheWhileLooop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
