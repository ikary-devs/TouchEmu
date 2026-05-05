using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.SendMessages
{
    public class ServerSelectionMessage : CallNetworkMessage
    {

	    public int serverId;


        public ServerSelectionMessage()
        {
        }

        public ServerSelectionMessage(int serverId)
        {
            this.serverId = serverId;

        }
    }
}