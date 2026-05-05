using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.SendMessages
{
    public class InteractiveUseRequestMessage : CallNetworkMessage
    {

	    public int elemId;
	    public int skillInstanceUid;


        public InteractiveUseRequestMessage()
        {
        }

        public InteractiveUseRequestMessage(int elemId, int skillInstanceUid)
        {
            this.elemId = elemId;
            this.skillInstanceUid = skillInstanceUid;

        }
    }
}