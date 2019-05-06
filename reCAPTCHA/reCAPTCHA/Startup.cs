using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(reCAPTCHA.Startup))]
namespace reCAPTCHA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
