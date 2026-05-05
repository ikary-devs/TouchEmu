using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class kpiStartSessionMessage : NetworkMessage
    {

	    public int sessionId;


        public kpiStartSessionMessage()
        {
        }

        public kpiStartSessionMessage(int sessionId)
        {
            this.sessionId = sessionId;

        }
    }
}