using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.SendMessages
{
    public class OfflineOptionsUpdateRequestMessage : CallNetworkMessage
    {

	    public string options;


        public OfflineOptionsUpdateRequestMessage()
        {
        }

        public OfflineOptionsUpdateRequestMessage(string options)
        {
            this.options = options;

        }
    }
}