using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchEmu.Core.Ankama.Protocol.Messages
{
    public class KamasUpdateMessage : NetworkMessage
    {

	    public int kamasTotal;


        public KamasUpdateMessage()
        {
        }

        public KamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;

        }
    }
}