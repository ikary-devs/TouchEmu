using System;
using TouchEmu.Core.Ankama.Protocol.Utils;
using TouchEmu.Core.Common.Config;
using TouchEmu.Server.Game.Network;

namespace TouchEmu.Server.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TouchEmu - Emulator for latest version of Dofus Touch by Ten.");

            //Apply config           
            NLog.LogManager.Configuration = LoggerConfig.GetConfig();
            
            //initialize
            Container.Initialize();
            
            var httpGameServer = new HttpServer("http://localhost:666");
            httpGameServer.Start().Wait();

        }
    }
}