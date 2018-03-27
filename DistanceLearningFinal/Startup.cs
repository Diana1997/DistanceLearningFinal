using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DistanceLearningFinal.Startup))]
namespace DistanceLearningFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
