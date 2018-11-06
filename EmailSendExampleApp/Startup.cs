using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailSendExampleApp.Startup))]
namespace EmailSendExampleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
