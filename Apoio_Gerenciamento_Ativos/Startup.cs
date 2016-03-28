using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apoio_Gerenciamento_Ativos.Startup))]
namespace Apoio_Gerenciamento_Ativos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
