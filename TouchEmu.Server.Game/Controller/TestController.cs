using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using EmbedIO.WebApi;

namespace TouchEmu.Server.Game.Controller
{
    public class TestController : WebApiController
    {
        [Route(HttpVerbs.Get, "/hello", false)]
        public async Task hello()
        {
        }
    }
}