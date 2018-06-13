using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AngularSafariDownload.Startup))]

namespace AngularSafariDownload
{
    using Microsoft.Owin.Cors;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
