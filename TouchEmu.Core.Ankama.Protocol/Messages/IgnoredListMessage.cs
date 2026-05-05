using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class IgnoredListMessage : NetworkMessage
    {

	    public int[] ignoredList;


        public IgnoredListMessage()
        {
        }

        public IgnoredListMessage(int[] ignoredList)
        {
            this.ignoredList = ignoredList;

        }
    }
}