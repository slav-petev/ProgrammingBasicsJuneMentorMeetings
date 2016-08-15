using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleJQueryCalendar.Startup))]
namespace SampleJQueryCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
