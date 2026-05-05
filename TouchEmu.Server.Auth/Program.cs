using System;
using System.IO;
using System.Reflection;
using TouchEmu.Core.Common.Config;
using TouchEmu.Server.Auth.Managers;
using TouchEmu.Server.Auth.Proxy;
using NLog;
using NLog.Conditions;
using NLog.Targets;

namespace TouchEmu.Server.Auth
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

            var proxyServer = new ProxyServer("http://localhost:3000");
            proxyServer.Start().Wait();
        }
    }
}