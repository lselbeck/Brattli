using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brattli2.Startup))]
namespace Brattli2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
