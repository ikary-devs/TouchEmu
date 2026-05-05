using TouchEmu.Core.Common.Entity;
using TouchEmu.Core.Common.Network;
using EmbedIO.WebSockets;

namespace TouchEmu.Server.Game.Network
{
    public class GameClient : Client
    {
        public Character Character { get; set; }
        
        public GameClient(string contextId, IWebSocketContext context) : base(contextId, context)
        {
        }
    }
}