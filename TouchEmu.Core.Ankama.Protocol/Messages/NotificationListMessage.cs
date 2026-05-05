using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class NotificationListMessage : NetworkMessage
    {

	    public int[] flags;


        public NotificationListMessage()
        {
        }

        public NotificationListMessage(int[] flags)
        {
            this.flags = flags;

        }
    }
}