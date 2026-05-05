using System;
using System.Threading.Tasks;
using TouchEmu.Core.Common.Network;
using EmbedIO.WebSockets;

namespace TouchEmu.Server.Game.Network
{
    public class GameServer : AbstractServer
    {
        public GameServer(string urlPath) : base(urlPath, false)
        {
        }
        
        protected override Task OnClientConnectedAsync(IWebSocketContext context)
        {
            // Console.WriteLine($"Client {context.Id} connected");
            this._logger.Info($"Client {context.Id} connected");
            
            var client = new GameClient(context.Id, context);
            client.OnDisconnect += DisconnectEventHandler;
            client.SendMessage += SendMessageEventHandler;
            
            this.Clients.TryAdd(context.Id, client);

            SendAsync(context, "0{\"sid\":\"h-Tc6sbvNVUqwrImAL-o\",\"upgrades\":[],\"pingInterval\":25000,\"pingTimeout\":5000}");

            return Task.CompletedTask;
        }
    }
}